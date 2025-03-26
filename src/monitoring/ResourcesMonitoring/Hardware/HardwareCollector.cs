using LibreHardwareMonitor.Hardware;
using System.Text.RegularExpressions;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;
using Vordr.ResourcesMonitoring.Windows.Hardware.Constants;

namespace Vordr.ResourcesMonitoring.Windows.Hardware;

public partial class HardwareCollector : IHardwareCollector
{
    private static Computer _computer = new();
    public HardwareReport Collect(MonitoringConfiguration monitoringConfiguration)
    {
        var hardwareReport = new HardwareReport();

        ReloadComputer(monitoringConfiguration);
        
        RetryPolicy.ExecuteWithRetry(() =>
        {
            _computer.Open();
            _computer.Accept(new HardwareMonitorVisitor());
            
            object lockObject = new object();

Parallel.ForEach(_computer.Hardware, hardware =>
{
    switch (hardware.HardwareType)
    {
        case HardwareType.Cpu:
            {
                if (monitoringConfiguration.MonitorCpu == MonitoringStatus.Enabled)
                {
                    var cpuResult = HandleCpuHardware(hardware);
                    lock (lockObject)
                    {
                        hardwareReport.Cpu = cpuResult;
                    }
                }
            }
            break;
        case HardwareType.GpuAmd or HardwareType.GpuNvidia or HardwareType.GpuIntel:
            {
                if (monitoringConfiguration.MonitorGpu == MonitoringStatus.Enabled)
                {
                    var gpuResult = HandleGpuHardware(hardware);
                    lock (lockObject)
                    {
                        hardwareReport.Gpu = gpuResult;
                    }
                }
            }
            break;
        case HardwareType.Memory:
            {
                if (monitoringConfiguration.MonitorRam == MonitoringStatus.Enabled)
                {
                    var ramResult = HandleRamHardware(hardware);
                    lock (lockObject)
                    {
                        hardwareReport.Ram = ramResult;
                    }
                }
            }
            break;
        case HardwareType.Network:
            {
                if (monitoringConfiguration.MonitorNetwork == MonitoringStatus.Enabled)
                {
                    var result = HandleNetworkHardware(hardware);
                    if (result != null)
                    {
                        lock (lockObject)
                        {
                            hardwareReport.Networks.Add(result);
                        }
                    }
                }
            }
            break;
        case HardwareType.Battery:
            {
                if (monitoringConfiguration.MonitorPowerSupply == MonitoringStatus.Enabled)
                {
                    var batteryResult = HandlePowerSupplyHardware(hardware);
                    lock (lockObject)
                    {
                        hardwareReport.Battery = batteryResult;
                    }
                }
            }
            break;
    }
});
            _computer.Reset();
            _computer.Close();    
            
        },  maxRetries: 10);
        
        if(monitoringConfiguration.MonitorDrives is MonitoringStatus.Enabled)
            hardwareReport.Drives = RetrieveDrivesInformation();
        return hardwareReport;
    }

    private static CpuReport HandleCpuHardware(IHardware hardware)
    {
        double totalCpuLoad = 0;
        double temperature = 0;
        var coresLoad = new List<double>();
        
        
        
        foreach (var sensor in hardware.Sensors)
        {
            switch (sensor.SensorType)
            {
                case SensorType.Load when sensor.Name.Contains("total", StringComparison.OrdinalIgnoreCase):
                    {
                        if(sensor.Value.HasValue)
                            totalCpuLoad = sensor.Value.GetValueOrDefault();
                        break;
                    }
                case SensorType.Load:
                    {
                        if (ContainsNumberRegex().IsMatch(sensor.Name))
                        {
                            if(sensor.Value.HasValue)
                                coresLoad.Add(sensor.Value.GetValueOrDefault());
                        
                        }
                        break;
                    }
                case SensorType.Temperature:
                    temperature = sensor.Value.GetValueOrDefault();
                    break;
            }
            if(totalCpuLoad > 0 && temperature > 0)
                break;
        }
        if (totalCpuLoad is 0)
            totalCpuLoad = coresLoad.Sum() / coresLoad.Count;

        return new CpuReport
        {
            AvgUsage = totalCpuLoad.RoundUp(),
            Temperature = temperature,
            CapturedAtUtc = DateTime.UtcNow
        };

    }
    private static GpuReport HandleGpuHardware(IHardware hardware)
    {
        double load = 0;
        double temperature = 0;
        double clock = 0;
        foreach (var sensor in hardware.Sensors)
        {
            if(sensor.SensorType == SensorType.Load && sensor.Name.Contains("core", StringComparison.OrdinalIgnoreCase))
                load = sensor.Value.GetValueOrDefault();
            if(sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("core", StringComparison.OrdinalIgnoreCase))
                temperature = sensor.Value.GetValueOrDefault();
            if(sensor.SensorType == SensorType.Clock && sensor.Name.Contains("core", StringComparison.OrdinalIgnoreCase))
                clock = sensor.Value.GetValueOrDefault();
        
            if(load != 0 && temperature != 0 && clock != 0)
                break;
                
        }

        return new GpuReport
        {
            AvgLoad = load.RoundUp(), Temperature = temperature, Clock = clock, CapturedAtUtc = DateTime.UtcNow
        };

    }
    private static RamReport HandleRamHardware(IHardware hardware)
    {
        double availableMemory = 0;
        double usedMemory = 0;

        foreach (var sensor in hardware.Sensors)
        {
            if(sensor.SensorType == SensorType.Data && sensor.Name.Contains("used", StringComparison.OrdinalIgnoreCase)
                                                    && !sensor.Name.Contains("virtual", StringComparison.OrdinalIgnoreCase))
                usedMemory = sensor.Value.GetValueOrDefault();
            if(sensor.SensorType == SensorType.Data && sensor.Name.Contains("Available", StringComparison.OrdinalIgnoreCase)
                                                    && !sensor.Name.Contains("virtual", StringComparison.OrdinalIgnoreCase))
                availableMemory = sensor.Value.GetValueOrDefault();
            if(availableMemory != 0 && usedMemory != 0)
                break;
        }

        return new RamReport
        {
            AvailableMemory = availableMemory.RoundUp(),
            UsedMemory = usedMemory.RoundUp(),
            CapturedAtUtc = DateTime.UtcNow
        };
    }
    private static List<DriveReport> RetrieveDrivesInformation()
    {
        string[] possibleDrives = ["C:", "D:", "E:", "F:", "G:", "H:", "I:", "J:"];
        return possibleDrives.Select(RetrieveDriveInformation).OfType<DriveReport>().ToList();
    }

    private static DriveReport? RetrieveDriveInformation(string name)
    {
        try
        {
            var drive = new DriveInformation(name);
            return new DriveReport(
                drive.Name, 
                drive.FreeSpace.ToGb().RoundUp(), 
                drive.TotalSize.ToGb().RoundUp(),
                DateTime.UtcNow
            );
        }
        catch (Exception)
        {
            // ignored

        }
        return null;
    }
    private static NetworkReport? HandleNetworkHardware(IHardware hardware)
    {
        double dataUploaded = 0; 
        double dataDownloaded = 0; 
        double downloadSpeed = 0; 
        double uploadSpeed = 0; 
        foreach (var sensor in hardware.Sensors)
        {
            if(sensor.SensorType == SensorType.Data && sensor.Name.Contains(NetworkConstants.DataUploaded, StringComparison.OrdinalIgnoreCase))
                dataUploaded = sensor.Value.GetValueOrDefault();
            
            if(sensor.SensorType == SensorType.Data && sensor.Name.Contains(NetworkConstants.DataDownloaded, StringComparison.OrdinalIgnoreCase))
                dataDownloaded = sensor.Value.GetValueOrDefault();
            
            if(sensor.SensorType == SensorType.Throughput && sensor.Name.Contains(NetworkConstants.DownloadSpeed, StringComparison.OrdinalIgnoreCase))
                downloadSpeed = sensor.Value.GetValueOrDefault();
            
            if(sensor.SensorType == SensorType.Throughput && sensor.Name.Contains(NetworkConstants.UploadSpeed, StringComparison.OrdinalIgnoreCase))
                uploadSpeed = sensor.Value.GetValueOrDefault();
            if (dataUploaded != 0 && dataDownloaded != 0 && downloadSpeed != 0 && uploadSpeed != 0)
                break;
        }
        if (dataUploaded != 0 || dataDownloaded != 0 || downloadSpeed != 0 || uploadSpeed != 0)
            return new NetworkReport
            {
                Network = hardware.Name,
                DataUploaded = dataUploaded,
                DataDownloaded = dataDownloaded,
                DownloadSpeed = downloadSpeed,
                UploadSpeed = uploadSpeed,
                CapturedAtUtc = DateTime.UtcNow
            };
        return null;
    }
    private static PowerSupplyReport HandlePowerSupplyHardware(IHardware hardware)
    {
        double degradationLevel = 0; 
        double chargeLevel = 0; 
        foreach (var sensor in hardware.Sensors)
        {
            if(sensor.SensorType == SensorType.Level && sensor.Name.Contains("Degradation", StringComparison.OrdinalIgnoreCase))
                degradationLevel =  sensor.Value.GetValueOrDefault().RoundUp();
            
            if(sensor.SensorType == SensorType.Level && sensor.Name.Contains("charge", StringComparison.OrdinalIgnoreCase)&& sensor.Name.Contains("level", StringComparison.OrdinalIgnoreCase))
                chargeLevel = sensor.Value.GetValueOrDefault();
            
            if (degradationLevel != 0 && chargeLevel != 0 )
                break;
        }
        return new PowerSupplyReport
        {
            DegradationLevel = degradationLevel,
            ChargeLevel = chargeLevel,
            CapturedAtUtc = DateTime.UtcNow
        };
    }

    private static void ReloadComputer(MonitoringConfiguration monitoringConfiguration)
    {
        _computer = new Computer();
        if (monitoringConfiguration.MonitorCpu is MonitoringStatus.Enabled)
            _computer.IsCpuEnabled = true;
        if (monitoringConfiguration.MonitorGpu is MonitoringStatus.Enabled)
            _computer.IsGpuEnabled = true;
        if (monitoringConfiguration.MonitorRam is MonitoringStatus.Enabled)
            _computer.IsMemoryEnabled = true;
        if (monitoringConfiguration.MonitorStorageDevices is MonitoringStatus.Enabled)
            _computer.IsStorageEnabled = true;
        if (monitoringConfiguration.MonitorNetwork is MonitoringStatus.Enabled)
            _computer.IsNetworkEnabled = true;
        if (monitoringConfiguration.MonitorPeripherals is MonitoringStatus.Enabled)
            _computer.IsPsuEnabled = true;
        if (monitoringConfiguration.MonitorPowerSupply is MonitoringStatus.Enabled)
        {
            _computer.IsPsuEnabled = true;
            _computer.IsBatteryEnabled = true;
        }
        _computer.Reset();
    }

    [GeneratedRegex(@"\d")]
    private static partial Regex ContainsNumberRegex();
    
}
