using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Hardware.Components;
using Vordr.Application.Models.Process;
using Vordr.Common.Messaging.Messages.HardwareComponents;
using Vordr.Common.Messaging.Messages.Process;
using Vordr.Domain.Entities;
using Vordr.Domain.Entities.Components;

namespace Vordr.Application.Hardware.Commands.UploadHardwareMetrics;

public static class UploadHardwareMetricsMapper
{
    public static HardwareReport ToHardwareReport(this Vordr.Common.Messaging.Messages.HardwareReports.HardwareReport report)
    {
        if(report == null || report.Cpu is null || report.Ram is null || report.Gpu is null || report.Battery is null)
            return null!;
        return new()
        {
            Cpu = new CpuReport
            {
                AvgUsage = report.Cpu.AvgUsage, Temperature = report.Cpu.Temperature, CapturedAtUtc = report.Cpu.CapturedAtUtc,
            },
            Drives = report.Drives.ConvertAll(x => new DriveReport(x.DriveName, x.DriveFreeSpace, x.DriveTotalSize, x.CapturedAtUtc)),
            Gpu = new GpuReport
            {
                AvgLoad = report.Gpu.AvgLoad, Temperature = report.Gpu.Temperature, Clock = report.Gpu.Clock, CapturedAtUtc = report.Gpu.CapturedAtUtc,
            },
            Networks = report.Networks.ConvertAll(x => new NetworkReport
            {
                Network = x.Network,
                DataUploaded = x.DataUploaded,
                DataDownloaded = x.DataDownloaded,
                DownloadSpeed = x.DownloadSpeed,
                UploadSpeed = x.UploadSpeed,
                CapturedAtUtc = x.CapturedAtUtc,
            }),
            Ram = new RamReport
            {
                AvailableMemory = report.Ram.AvailableMemory, UsedMemory = report.Ram.UsedMemory, CapturedAtUtc = report.Ram.CapturedAtUtc,
            },
            Battery = new PowerSupplyReport
            {
                DegradationLevel = report.Battery.DegradationLevel, ChargeLevel = report.Battery.ChargeLevel, CapturedAtUtc = report.Battery.CapturedAtUtc,
            }
        };
    }

    public static IEnumerable<ProcessInformation> ToProcessInformation(this List<ProcessInfo>? processInformation)
    {
        return processInformation!.ConvertAll(x => new ProcessInformation
        {
            Pid = x.Pid,
            Name = x.Name,
            StartTime = x.StartTime,
            Icon = x.Icon,
            Path = x.Path,
            Priority = x.Priority,
            Company = x.Company,
            Version = x.Version,
            Architecture = x.Architecture,
            CpuUsage = x.CpuUsage,
            RamUsage = x.RamUsage,
            IsSystemProcess = x.IsSystemProcess,
            ThreadCount = x.ThreadCount,
            HandleCount = x.HandleCount
        });
    }

    public static HardwareComponents ToHardwareComponents(this HardwareData hardwareData)
    {
        return new HardwareComponents(
            new BatteryInfo(hardwareData.Battery.Name, hardwareData.Battery.DesignedCapacity, hardwareData.Battery.Manufacturer, hardwareData.Battery.FullChargedCapacity, hardwareData.Battery.Chemistry), 
            new CpuInfo(hardwareData.Cpu.Name, hardwareData.Cpu.Cores), 
             hardwareData.Drives.Select(x => new InfoDrive(x.DriveFormat, x.DriveLabel, x.DriveType, x.RootDirectory)),
             hardwareData.Gpu.Select(x => new GpuInfo(x.Name, x.DeviceId)), 
            hardwareData.Network.Select(x => new NetworkInfo(x.Name, x.Description, x.IsReceiveOnly, x.InterfaceType, x.SupportMulticast))
            );
    }

}
