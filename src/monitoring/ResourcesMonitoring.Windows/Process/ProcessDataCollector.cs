using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Models.Process;
using Vordr.ResourcesMonitoring.Windows.Convertors;
using Vordr.ResourcesMonitoring.Windows.Process.Extensions;
using Vordr.ResourcesMonitoring.Windows.Process.Properties;

namespace Vordr.ResourcesMonitoring.Windows.Process;

public class ProcessDataCollector  : IProcessDataCollector
{
public async Task<IEnumerable<ProcessInformation>> GetCurrentProcesses()
        {
            // Get all running processes
            var processes = System.Diagnostics.Process.GetProcesses();

            var processInfoList = new List<ProcessInformation>();

            var options = new ParallelOptions { MaxDegreeOfParallelism = 20 };
            await Parallel.ForEachAsync(processes,options, (process, cancellationToken) =>
            {
                try
                {
                    var processInfo =  GetProcessInfoAsync(process, cancellationToken);
                    if (processInfo != null)
                        processInfoList.Add(processInfo);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                return ValueTask.CompletedTask;
            });

            return processInfoList;
        }

        private static  ProcessInformation? GetProcessInfoAsync(System.Diagnostics.Process process, CancellationToken cancellationToken)
        {
            try
            {
                var processInfo = new ProcessInformation
                {
                    Pid = process.GetId(),
                    Name = process.GetName(),
                    StartTime = process.GetStartTime(),// process.StartTime,
                    Path = process.GetPath(),
                    Priority = process.GetPriority(),
                    Company = process.GetCompany(),
                    Version = process.GetVersion(),
                    Architecture = process.GetProcessArchitecture(),
                    User = process.GetUser(),
                    CpuUsage = process.GetCpuUsage(),
                    RamUsage = process.GetRamUsage(),
                    MaxWorkingSetMb = process.GetMaxWorkingSetMb(),
                    GpuUsage = process.GetGpuUsage(),
                    ThreadCount = process.GetThreadsCount(),
                    HandleCount = process.GetHandleCount(),
                    DiskReadMb = 0,//await Task.Run(() => process.GetDiskIoMb(Constants.DiskReadBytes), cancellationToken),
                    DiskWriteMb = 0, //await Task.Run(() => process.GetDiskIoMb(Constants.DiskReadBytes), cancellationToken),
                    NetworkSentBytes = 0,// await GetNetworkSentBytesAsync(process),
                    NetworkReceivedBytes = 0,//await GetNetworkReceivedBytesAsync(process),
                    Icon = []//process.GetIcon()
                };

                return processInfo;
            }
            catch (Exception)
            {
                return null; // In case of any exception, return null for this process
            }
        }
}
