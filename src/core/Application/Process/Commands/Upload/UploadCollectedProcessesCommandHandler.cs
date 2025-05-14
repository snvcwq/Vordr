using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Mappings.Process;
using Vordr.Application.Models.Process;
using Vordr.Application.Notfication.SendNotfication;
using Vordr.Application.StaticData;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Application.Process.Commands.Upload;

// ReSharper disable once UnusedType.Global
public class UploadCollectedProcessesCommandHandler(
    ILogger<UploadCollectedProcessesCommand> logger,
    IProcessDataRepository processDataRepository,
    IProcessMetricsRepository processMetricsRepository,
    IAlertRepository alertRepository,
    ISender sender,
    IPushNotifiction pushNotifiction,
    IWorkstationRepository workstationRepository,
    INotificationRepository notificationRepository
) : IRequestHandler<UploadCollectedProcessesCommand>
{
    public async Task Handle(UploadCollectedProcessesCommand request, CancellationToken cancellationToken)
    {
        StaticProcesses.UpdateData(request.ProcessList.ToList(), request.clientId);
        
        var client =  await workstationRepository.GetWorkstationAsync(request.clientId);
        var processCpu = await alertRepository.GetByTypeAsync(AlertType.ProcessUsesCpuMoreThan);
        var processRam = await alertRepository.GetByTypeAsync(AlertType.ProcessUsesRamMoreThan);
        
        var config =  await notificationRepository.GetAsync();
        if (config != null && (config.EmailEnabled || config.PushNotificationEnabled))
        {
            if (processCpu.Enabled && int.TryParse(processCpu.Value, out var cpuThreshold))
            {
                var process = request.ProcessList.FirstOrDefault(p => p.CpuUsage >= cpuThreshold);
                if (process != null)
                {
                    var message = $"We noticed that process '{process.Name}' (PID: {process.Pid}) for {client?.Name} is using {process.CpuUsage:F2}% CPU, which exceeds the alert threshold of {cpuThreshold}%. Please investigate.";
                    if(config.EmailEnabled)
                        await sender.Send(new SendNotificationCommand(message, AlertType.ProcessUsesCpuMoreThan), cancellationToken);
                    if(config.PushNotificationEnabled)
                        pushNotifiction.Send(message, AlertType.ProcessUsesCpuMoreThan);
                }
            }

            if (processRam.Enabled && int.TryParse(processRam.Value, out var ramThreshold))
            {
                var process = request.ProcessList.FirstOrDefault(p => p.RamUsage >= ramThreshold);
                if (process != null)
                {
                    var message = $"We noticed that process '{process.Name}' (PID: {process.Pid}) for {client?.Name} is using {process.RamUsage:F2} MB RAM, which exceeds the alert threshold of {ramThreshold} MB. Please investigate.";
                    if(config.EmailEnabled)
                        await sender.Send(new SendNotificationCommand(message, AlertType.ProcessUsesRamMoreThan), cancellationToken);
                    if(config.PushNotificationEnabled)
                        pushNotifiction.Send(message, AlertType.ProcessUsesRamMoreThan);

                }
            }
        }
        var retrievedProcesses = request.ProcessList.ToList();
        var processOsIdentifiers = retrievedProcesses.Select(p => new ProcessOsIdentifier(p.Name, p.Path, p.Version, p.Company));
        var storedProcessesResult = await processDataRepository.RetrieveAsync(processOsIdentifiers);

        var updatedPidRequests = new List<UpdatePidRequest>();

        storedProcessesResult.Switch(
            storedProcesses =>
            {
                updatedPidRequests.AddRange(DefineProcessesThatChangedPid(storedProcesses, retrievedProcesses));
            },
            errors => logger.LogError(
                "An error occured when retrieving data processes to change their PID. Will not update PID. Error: {error}",
                errors.First().Description));

        if (updatedPidRequests.Count > 0)
        {
            logger.LogWarning("Will update PID for {changedPidProcessesCout} processes.", updatedPidRequests.Count);
            await UpdatePidForProcessesAsync(updatedPidRequests);
        }

        var processMetricsResult = await processDataRepository.RetrieveAsync(retrievedProcesses.Select(p => new ProcessOsIdentifier(p.Name, p.Path, p.Version, p.Company)));

        var storedProcessData = new List<ProcessData>();

        //now stored and retrieved data have the same Pid, so we can update data for every process 
        processMetricsResult.Switch(
            storedProcesses => { storedProcessData.AddRange(storedProcesses); },
            errors =>
            {
                logger.LogError(
                    "An error occured when retrieving processes to update. Will try to upload all processes to db as new. Errors: {errors} .",
                    errors.Print());
            });

        

        var updateProcessesRequest =  DefineUpdateProcessesRequest(retrievedProcesses, storedProcessData, request.clientId);

        await PerformUpdateProcessesRequestsAsync(updateProcessesRequest);
    }

    private async Task PerformUpdateProcessesRequestsAsync(UpdateProcessesRequest request)
    {
        foreach (var updateRequest in request.CreateProcesses)
        {
            var result = await processDataRepository.UploadAsync(updateRequest.Process);
            result.Switch(async void (objectId) =>
                {
                    try
                    {
                        await processMetricsRepository.UploadAsync(updateRequest.Stats.ToProcessMetrics(objectId));
                    }
                    catch (Exception)
                    {
                        logger.LogError("Error occured when trying to update processes data");
                    }
                },
                errors => logger.LogError("Error occured when trying to update processes data. Errors: {errors}",
                    errors.Print()));
        }

        foreach (var updateRequest in request.UpdateProcesses)
        {
            var result = await processDataRepository.UpdateAsync(updateRequest.Process);
            result.Switch(async void (objectId) =>
                {
                    try
                    {
                        await processMetricsRepository.UploadAsync(updateRequest.Stats.ToProcessMetrics(objectId));
                    }
                    catch (Exception)
                    {
                        logger.LogError("Error occured when trying to update processes data");
                    }
                },
                errors => logger.LogError("Error occured when trying to update processes data. Errors: {errors}",
                    errors.Print()));
        }
    }

    private async Task UpdatePidForProcessesAsync(IEnumerable<UpdatePidRequest> request)
    {
        var updatePidRequests = request.ToList();
        var dataUpdatePidResult = await processDataRepository.ChangePidAsync(updatePidRequests);

        dataUpdatePidResult.Switch(
            _ => { logger.LogInformation("Pid list for data was successfully updated."); },
            error => logger.LogError("Error occured when updating pid for data. Errors: {errors}.", error.Print())
        );
    }

    private static UpdateProcessesRequest DefineUpdateProcessesRequest(IList<ProcessInformation> retrievedProcesses,
        IList<ProcessData> storedProcesses, string clientId)
    {
            var storedProcessesDictionary = storedProcesses.ToDictionary(pd => (pd.Name, pd.Path, pd.Manufacturer, pd.Version));

        var newProcessesData = new List<CreateProcessDataRequest>();
        var updateProcessesData = new List<UpdateProcessDataRequest>();
        foreach (var retrievedProcess in retrievedProcesses)
        {
            storedProcessesDictionary.TryGetValue((retrievedProcess.Name, retrievedProcess.Path, retrievedProcess.Company, retrievedProcess.Version), out var storedProcess);

            if (storedProcess is null)
                newProcessesData.Add(CreateProcessData(retrievedProcess, clientId));
            else
                updateProcessesData.Add(UpdateProcessData(storedProcess, retrievedProcess));
        }

        return new UpdateProcessesRequest(newProcessesData, updateProcessesData);
    }

    private static UpdateProcessDataRequest UpdateProcessData(ProcessData storedData, ProcessInformation retrievedData)
    {
        storedData.Pid = retrievedData.Pid;
        storedData.Name = retrievedData.Name;
        storedData.Architecture = retrievedData.Architecture;
        storedData.Path = retrievedData.Path;
        storedData.Icon = retrievedData.Icon;
        storedData.Manufacturer = retrievedData.Company;
        storedData.Priority = retrievedData.Priority;
        storedData.Version = retrievedData.Version;
        storedData.StartTime = retrievedData.StartTime;
        storedData.IsSystemProcess = retrievedData.IsSystemProcess;
        var stats = CreateProcessStats(retrievedData);
        return new UpdateProcessDataRequest(storedData, stats);
    }

    private static CreateProcessDataRequest CreateProcessData(ProcessInformation retrievedData, string clientId)
    {
        var data = new ProcessData
        {
            Pid = retrievedData.Pid,
            Name = retrievedData.Name,
            Architecture = retrievedData.Architecture,
            Path = retrievedData.Path,
            Icon = retrievedData.Icon,
            Manufacturer = retrievedData.Company,
            Priority = retrievedData.Priority,
            Version = retrievedData.Version,
            StartTime = retrievedData.StartTime,
            IsSystemProcess = retrievedData.IsSystemProcess,
            ClientId = clientId
        };
        var stats = CreateProcessStats(retrievedData);
        return new CreateProcessDataRequest(data, stats);
    }

    private static ProcessStats CreateProcessStats(ProcessInformation retrievedData)
    {
        return new ProcessStats
        {
            CpuUsage = retrievedData.CpuUsage,
            RamUsage = retrievedData.RamUsage,
            ThreadCount = retrievedData.ThreadCount,
            HandleCount = retrievedData.HandleCount,
        };
    }

    private List<UpdatePidRequest> DefineProcessesThatChangedPid(
        IEnumerable<ProcessData> storedProcesses, 
        IEnumerable<ProcessInformation> retrievedProcesses)
    {
        var storedProcessesDictionary = storedProcesses
            .GroupBy(pd => (pd.Name, pd.Path, pd.Manufacturer, pd.Version))
            .ToDictionary(g => g.Key, g => g.ToList());

        List<UpdatePidRequest> updateProcessRequests = [];

        foreach (var retrievedProcess in retrievedProcesses)
        {
            var key = (retrievedProcess.Name, retrievedProcess.Path, retrievedProcess.Company, retrievedProcess.Version);

            // Check if there are any stored processes with the same key
            if (!storedProcessesDictionary.TryGetValue(key, out var storedProcessesList))
                continue;

            
            foreach (var storedProcess in storedProcessesList)
            {
                // Compare the PIDs
                if (retrievedProcess.Pid == storedProcess.Pid)
                    continue;

                // Add to the update requests
                updateProcessRequests.Add(new UpdatePidRequest(storedProcess.Pid, retrievedProcess.Pid));
                logger.LogWarning("Will change Pid from <{oldPid}> to <{newPid}> for process with name {processName}",
                    storedProcess.Pid, retrievedProcess.Pid, retrievedProcess.Name);
            }
        }

        return updateProcessRequests;
    }
}
