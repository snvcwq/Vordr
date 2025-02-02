using System.Diagnostics.CodeAnalysis;
using System.Management;
using Vordr.ResourcesMonitoring.Windows.Convertors;

namespace Vordr.ResourcesMonitoring.Windows.Process.Extensions;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
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
        try
        {
            if (process.ProcessName == "Telegram")
            {
                const int x = 10;
                Console.WriteLine(x);
            }
            return process.MainModule?.FileVersionInfo.CompanyName ?? string.Empty;
        }
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

    internal static string GetUser(this System.Diagnostics.Process process)
    {
        try
        {
            return string.Empty;
/*
            var query = $"SELECT * FROM Win32_Process WHERE ProcessId = {process.Id}";
            using var searcher = new ManagementObjectSearcher("root\\CIMV2", query);
            foreach (var o in searcher.Get())
            {
                var obj = (ManagementObject)o;
                var args = new object[2];
                var result = Convert.ToInt32(obj.InvokeMethod("GetOwner", args));
                
                if (result == 0) // Success
                {
                    return args[0].ToString() ?? Constants.Unknown; // args[0] contains the username
                }
            }
*/
        }
        catch
        {
            // Ignored
        }

        return Constants.Unknown;
    }
    
    
    internal static double GetCpuUsage(this System.Diagnostics.Process process)
    {
        // CPU usage needs a performance counter or sampling over time
        return 0;
    }
    
    internal static long GetRamUsage(this System.Diagnostics.Process process)
    {
        // CPU usage needs a performance counter or sampling over time
        return 0;
    }

    internal static double GetGpuUsage(this System.Diagnostics.Process process)
    {
        // GPU usage requires third-party libraries like OpenHardwareMonitor
        return 0;
    }

    internal static double GetDiskIoMb(this System.Diagnostics.Process process, string propertyName)
    {
        try
        {
            var query = $"SELECT {propertyName} FROM Win32_PerfRawData_PerfProc_Process WHERE IDProcess={process.Id}";
            using var searcher = new ManagementObjectSearcher(query);
            foreach (var obj in searcher.Get())
                return UnitConverter.KilobytesToMegabytes(Convert.ToInt64(obj[propertyName]));
        }
        catch
        {
            // ignored
        }

        return 0;
    }
    internal static double GetMaxWorkingSetMb(this System.Diagnostics.Process process)
    {
        try { return UnitConverter.BytesToMb(process.MaxWorkingSet); }
        catch { return 0; }
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
}
