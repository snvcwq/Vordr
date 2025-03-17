using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Mappings.Process;
using Vordr.Application.Models.Process;
using Vordr.Domain.Entities;

namespace Vordr.Application.Process.Commands.Upload;

// ReSharper disable once UnusedType.Global
public class UploadCollectedProcessesCommandHandler(
    ILogger<UploadCollectedProcessesCommand> logger,
    IProcessDataRepository processDataRepository,
    IProcessMetricsRepository processMetricsRepository
) : IRequestHandler<UploadCollectedProcessesCommand>
{
    public async Task Handle(UploadCollectedProcessesCommand request, CancellationToken cancellationToken)
    {
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

        

        var updateProcessesRequest =  DefineUpdateProcessesRequest(retrievedProcesses, storedProcessData);

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
        IList<ProcessData> storedProcesses)
    {
            var storedProcessesDictionary = storedProcesses.ToDictionary(pd => (pd.Name, pd.Path, pd.Manufacturer, pd.Version));

        var newProcessesData = new List<CreateProcessDataRequest>();
        var updateProcessesData = new List<UpdateProcessDataRequest>();
        foreach (var retrievedProcess in retrievedProcesses)
        {
            storedProcessesDictionary.TryGetValue((retrievedProcess.Name, retrievedProcess.Path, retrievedProcess.Company, retrievedProcess.Version), out var storedProcess);

            if (storedProcess is null)
                newProcessesData.Add(CreateProcessData(retrievedProcess));
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
        var stats = CreateProcessStats(retrievedData);
        return new UpdateProcessDataRequest(storedData, stats);
    }

    private static CreateProcessDataRequest CreateProcessData(ProcessInformation retrievedData)
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
            StartTime = retrievedData.StartTime
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
