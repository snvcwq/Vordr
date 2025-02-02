using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Models.Process;
using Vordr.Domain.Entities;

namespace Vordr.Application.Process.Commands;

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
        var processOsIdentifiers = retrievedProcesses.Select(p => new ProcessOsIdentifier(p.Name, p.Path, p.Version));
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

        var processMetricsResult = await processDataRepository.RetrieveAsync(retrievedProcesses.Select(rp => rp.Pid));

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

        var updateProcessesRequest = DefineUpdateProcessesRequest(retrievedProcesses, storedProcessData);

        await PerformUpdateProcessesRequestsAsync(updateProcessesRequest);
    }

    private async Task PerformUpdateProcessesRequestsAsync(UpdateProcessesRequest request)
    {
        var updateProcessDataResult =
            await processDataRepository.UpdateAsync(request.UpdateProcessesDataRequest.UpdatedProcesses);
        updateProcessDataResult.Switch(
            _ => logger.LogInformation("Process Data was successfully updated"),
            errors => logger.LogError("Error occured when trying to update processes data. Errors: {errors}",
                errors.Print()));

        var uploadProcessDataResult =
            await processDataRepository.UploadAsync(request.UpdateProcessesDataRequest.NewProcesses);
        uploadProcessDataResult.Switch(
            _ => logger.LogInformation("New process Data was successfully uploaded"),
            errors => logger.LogError("Error occured when trying to upload new  process data. Errors: {errors}",
                errors.Print()));

        var uploadProcessMetricsResult =
            await processMetricsRepository.UploadAsync(request.UpdateProcessesMetricsRequest.NewProcesses);
        uploadProcessMetricsResult.Switch(
            _ => logger.LogInformation("New process metrics was successfully uploaded"),
            errors => logger.LogError("Error occured when trying to upload new process metrics. Errors: {errors}",
                errors.Print()));
    }

    private async Task UpdatePidForProcessesAsync(IEnumerable<UpdatePidRequest> request)
    {
        var updatePidRequests = request.ToList();
        var metricsUpdatePidResult = await processMetricsRepository.ChangePidAsync(updatePidRequests);

        metricsUpdatePidResult.Switch(
            _ => { logger.LogInformation("Pid list for metrics was successfully updated."); },
            error => logger.LogError("Error occured when updating pid for metrics. Errors: {errors}.", error.Print())
        );
        var dataUpdatePidResult = await processDataRepository.ChangePidAsync(updatePidRequests);

        dataUpdatePidResult.Switch(
            _ => { logger.LogInformation("Pid list for data was successfully updated."); },
            error => logger.LogError("Error occured when updating pid for data. Errors: {errors}.", error.Print())
        );
    }

    private static UpdateProcessesRequest DefineUpdateProcessesRequest(IList<ProcessInformation> retrievedProcesses,
        IList<ProcessData> storedProcesses)
    {
        var storedProcessesDictionary = storedProcesses.ToDictionary(pd => pd.Pid);

        var newProcessesData = new List<ProcessData>();
        var updateProcessesData = new List<ProcessData>();
        var processesMetrics = new List<ProcessMetrics>();
        foreach (var retrievedProcess in retrievedProcesses)
        {
            storedProcessesDictionary.TryGetValue(retrievedProcess.Pid, out var storedProcess);

            if (storedProcess is null)
                newProcessesData.Add(CreateProcessData(retrievedProcess));
            else
                updateProcessesData.Add(UpdateProcessData(storedProcess, retrievedProcess));

            processesMetrics.Add(CreateProcessMetrics(retrievedProcess));
        }

        return new UpdateProcessesRequest(
            new UpdateProcessesDataRequest(newProcessesData, updateProcessesData),
            new UpdateProcessesMetricsRequest(processesMetrics));
    }

    private static ProcessData UpdateProcessData(ProcessData storedData, ProcessInformation retrievedData)
    {
        storedData.Pid = retrievedData.Pid;
        storedData.Name = retrievedData.Name;
        storedData.Architecture = retrievedData.Architecture;
        storedData.Path = retrievedData.Path;
        storedData.Icon = retrievedData.Icon;
        storedData.Manufacturer = retrievedData.Company;
        storedData.Priority = retrievedData.Priority;
        storedData.User = retrievedData.User;
        storedData.Version = retrievedData.Version;
        storedData.StartTime = retrievedData.StartTime;
        return storedData;
    }

    private static ProcessData CreateProcessData(ProcessInformation retrievedData)
    {
        return new ProcessData
        {
            Pid = retrievedData.Pid,
            Name = retrievedData.Name,
            Architecture = retrievedData.Architecture,
            Path = retrievedData.Path,
            Icon = retrievedData.Icon,
            Manufacturer = retrievedData.Company,
            Priority = retrievedData.Priority,
            User = retrievedData.User,
            Version = retrievedData.Version,
            StartTime = retrievedData.StartTime
        };
    }

    private static ProcessMetrics CreateProcessMetrics(ProcessInformation retrievedData)
    {
        return new ProcessMetrics
        {
            Pid = retrievedData.Pid,
            CpuUsage = retrievedData.CpuUsage,
            RamUsage = retrievedData.RamUsage,
            MaxWorkingSet = retrievedData.MaxWorkingSetMb,
            GpuUsage = retrievedData.GpuUsage,
            ThreadCount = retrievedData.ThreadCount,
            HandleCount = retrievedData.HandleCount,
            DiskReadMb = retrievedData.DiskReadMb,
            DiskWriteMb = retrievedData.DiskWriteMb,
            NetworkSentBytes = retrievedData.NetworkSentBytes,
            NetworkReceivedBytes = retrievedData.NetworkReceivedBytes
        };
    }

    private List<UpdatePidRequest> DefineProcessesThatChangedPid(IEnumerable<ProcessData> storedProcesses,
        IEnumerable<ProcessInformation> retrievedProcesses)
    {
        var storedProcessesDictionary = storedProcesses.ToDictionary(pd => (pd.Name, pd.Path, pd.Version));

        List<UpdatePidRequest> updateProcessRequests = [];

        foreach (var retrievedProcess in retrievedProcesses)
        {
            if (!storedProcessesDictionary.TryGetValue((retrievedProcess.Name, retrievedProcess.Path, retrievedProcess.Version),
                    out var storedProcess))
                continue;

            if (retrievedProcess.Pid == storedProcess.Pid)
                continue;

            updateProcessRequests.Add(new UpdatePidRequest(storedProcess.Pid, retrievedProcess.Pid));
            logger.LogWarning("Will change Pid from <{oldPid}> to <{newPid}> for process with name {processName}",
                storedProcess.Pid, retrievedProcess.Pid, retrievedProcess.Name);
        }

        return updateProcessRequests;
    }
}
