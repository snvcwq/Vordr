using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Management;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Models.Process;
using Vordr.ResourcesMonitoring.Windows.Process.Extensions;
using Vordr.ResourcesMonitoring.Windows.Process.Properties;

namespace Vordr.ResourcesMonitoring.Windows.Process;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
public class ProcessDataCollector : IProcessDataCollector
{
    public async Task<IEnumerable<ProcessInformation>> GetCurrentProcesses()
    {

        var processes = System.Diagnostics.Process.GetProcesses();

        var processInfoList = new List<ProcessInformation>();

        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = 5
        };
        /*
        var stopwatch = new Stopwatch();
        stopwatch.Start();
       foreach(var process in processes)
        {
            try
            {
                var processInfo = GetProcessInfoAsync(process, CancellationToken.None);
                if (processInfo != null)
                    processInfoList.Add(processInfo);
                Console.WriteLine($"finished process {process.ProcessName}. it took {stopwatch.ElapsedMilliseconds} milliseconds.");
                stopwatch.Restart();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        return GroupProcesses(processInfoList);*/
        await Parallel.ForEachAsync(processes, options, (process, cancellationToken) =>
        {
            try
            {
                var processInfo = GetProcessInfoAsync(process, cancellationToken);
                if (processInfo != null)
                    processInfoList.Add(processInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return ValueTask.CompletedTask;
        });
        return GroupProcesses(processInfoList);
    }

    private static ProcessInformation? GetProcessInfoAsync(System.Diagnostics.Process process, CancellationToken cancellationToken)
    {
        try
        {
            var processInfo = new ProcessInformation
            {
                Pid = process.GetId(),
                Name = process.GetName(),
                StartTime = process.GetStartTime(),
                Path = process.GetPath(),
                Priority = process.GetPriority(),
                Company = process.GetCompany(),
                Version = process.GetVersion(),
                Architecture = process.GetProcessArchitecture(),
                CpuUsage = process.GetCpuUsage().ConfigureAwait(false).GetAwaiter().GetResult(),
                RamUsage = process.GetRamUsage(),
                ThreadCount = process.GetThreadsCount(),
                HandleCount = process.GetHandleCount(),
                Icon = process.GetIcon(),
                IsSystemProcess = process.IsSystemProcess()
            };

            return processInfo;
        }
        catch (Exception)
        {
            return null;// In case of any exception, return null for this process
        }
    }


    private static List<ProcessInformation> GroupProcesses(List<ProcessInformation> processes)
    {
        var finalProcessesList = new List<ProcessInformation>();
        var processGroups = new Dictionary<(string ProcessName, string Path, string Company, string Version), List<ProcessInformation>>();
        foreach (var process in processes)
        {
            var processName = process.Name;

            var processPath = process.Path;
            var company = process.Company;
            var version = process.Version;

            processGroups.TryGetValue((processName, processPath, company, version), out var processGroup);
            if (processGroup is not null)
                processGroup.Add(process);
            else
                processGroups[(processName, processPath, company, version)] = [process];
        }
        foreach (var processGroup in processGroups)
            finalProcessesList.Add(MergeProcesses(processGroup.Value));
        return finalProcessesList;
    }
    
    private static ProcessInformation MergeProcesses(List<ProcessInformation> processes)
    {
            
        var process = new ProcessMergeResult();
        var iconProcess = processes.FirstOrDefault(p => p.Icon is not null);
        var isSystem = processes.All(p => p.IsSystemProcess);
        var icon = iconProcess?.Icon;
        var priorityProcess = processes.FirstOrDefault(p => p.Priority > 0);
        var priority = priorityProcess?.Priority ?? 0;
        process.Pid = 0;
        process.Name = processes.First().Name;
        process.StartTime = processes.First().StartTime;
        process.Icon = icon;
        process.Path = processes.First().Path;
        process.Priority = priority;
        process.Company = processes.First().Company;
        process.Version = processes.First().Version;
        process.Architecture = processes.First().Architecture;
        process.CpuUsage = processes.Sum(p => p.CpuUsage);
        process.RamUsage = processes.Sum(p => p.RamUsage);
        process.ThreadCount = processes.Sum(p => p.ThreadCount);
        process.HandleCount = processes.Sum(p => p.HandleCount);
        if(processes.Count is 1)
            process.Pid = processes.First().Pid;
        return new ProcessInformation
        {
            Pid = process.Pid,
            Name = process.Name,
            StartTime = process.StartTime,
            Icon = process.Icon,
            Path = process.Path,
            Priority = process.Priority,
            Company = process.Company,
            Version = process.Version,
            Architecture = process.Architecture,
            CpuUsage = process.CpuUsage,
            RamUsage = process.RamUsage,
            ThreadCount = process.ThreadCount,
            HandleCount = process.HandleCount,
            IsSystemProcess = isSystem
        };
    }
}
