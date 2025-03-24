using Vordr.ResourcesMonitoring.Windows.Convertors;

namespace Vordr.ResourcesMonitoring.Windows.Process.Extensions;

internal static class SystemProcessExtensions
{
    
    internal static int GetId(this System.Diagnostics.Process process) =>
        process.Id;
    
    internal static string GetName(this System.Diagnostics.Process process)
    {
        try { return process.ProcessName; }
        catch { return process.Id.ToString(); }
    }
    internal static DateTime GetStartTime(this System.Diagnostics.Process process)
    {
        try { return process.StartTime; }
        catch { return DateTime.MinValue; }
    }
    internal static string GetPath(this System.Diagnostics.Process process)
    {
        try { return process.MainModule?.FileName ?? string.Empty; }
        catch { return string.Empty; }
    }
    internal static int GetPriority(this System.Diagnostics.Process process)
    {
        try { return (int)process.PriorityClass; }
        catch { return 0; } 
    }
    
    internal static string GetCompany(this System.Diagnostics.Process process)
    {
        try { return process.MainModule?.FileVersionInfo.CompanyName ?? string.Empty; }
        catch 
        {
            // ignored
        }
        return Constants.Unknown;
    }
    
    internal static string GetVersion(this System.Diagnostics.Process process)
    {
        try { return process.MainModule?.FileVersionInfo.FileVersion ?? string.Empty; }
        catch { return string.Empty; }
    }
    
    internal static string GetProcessArchitecture(this System.Diagnostics.Process process)
    {
        return Environment.Is64BitProcess ? "x64" : "x86";
    }
    
    internal static async Task<double> GetCpuUsage(this System.Diagnostics.Process process)
    {
        try
        {
            var startTime = DateTime.UtcNow;
            var startCpuUsage = process.TotalProcessorTime;
            await Task.Delay(50);
    
            var endTime = DateTime.UtcNow;
            var endCpuUsage = System.Diagnostics.Process.GetProcessById(process.Id).TotalProcessorTime;
            var cpuUsedMs = (endCpuUsage - startCpuUsage).TotalMilliseconds;
            var totalMsPassed = (endTime - startTime).TotalMilliseconds;
            var cpuUsageTotal = cpuUsedMs / (Environment.ProcessorCount * totalMsPassed);
            if (cpuUsageTotal > 0)
            {
                var x = 10;
                var t = x;
            }
            return cpuUsageTotal * 100;
        }
        catch (Exception)
        {
            return 0;
        }
    }
    
    internal static double GetRamUsage(this System.Diagnostics.Process process)
    {
        return UnitConverter.BytesToMb(process.WorkingSet64);
    }
    
    internal static int GetThreadsCount(this System.Diagnostics.Process process)
    {
        try { return process.Threads.Count; }
        catch { return 0; }
    }
    
    internal static int GetHandleCount(this System.Diagnostics.Process process)
    {
        try { return process.HandleCount; }
        catch { return 0; }
    }
    
    internal static bool IsSystemProcess(this System.Diagnostics.Process process)
    {
        return SystemService.KnownSystemPaths.Any(x => x.ToLower().Contains(process.GetPath().ToLower()));
    }
}
