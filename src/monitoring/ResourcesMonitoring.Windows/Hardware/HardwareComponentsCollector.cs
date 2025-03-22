using LibreHardwareMonitor.Hardware;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text.RegularExpressions;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;
using Vordr.Domain.Entities.Components;

namespace Vordr.ResourcesMonitoring.Windows.Hardware;

public partial class HardwareComponentsCollector : IHardwareComponentsCollector
{
    private static Computer _computer = new();
    public HardwareComponents Collect()
    {
        BatteryInfo battery= new BatteryInfo(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        CpuInfo cpu = new CpuInfo(string.Empty, 0);
        List<InfoDrive> drive = [];
        List<GpuInfo> gpu = [];
        List<NetworkInfo> network = [];
        ReloadComputer();

        RetryPolicy.ExecuteWithRetry(() =>
        {
            _computer.Open();
            _computer.Accept(new HardwareMonitorVisitor());


            Parallel.ForEach(_computer.Hardware, hardware =>
            {
                switch (hardware.HardwareType)
                {
                    case HardwareType.Cpu:
                        cpu = HandleCpuHardware(hardware);
                        break;
                    case HardwareType.GpuAmd or HardwareType.GpuNvidia or HardwareType.GpuIntel:
                        gpu.Add(HandleGpuHardware(hardware));
                        break;
                    case HardwareType.Network:
                        {
                            var networkInfo = HandleNetworkHardware(hardware);
                            if(networkInfo is not null)
                                network.Add(networkInfo);
                        }
                        break;
                    case HardwareType.Battery:
                        battery = HandlePowerSupplyHardware(hardware);
                        break;
                }
            });
            _computer.Reset();
            _computer.Close();

        }, 10);


        drive = RetrieveDrivesInformation();


        return new HardwareComponents(battery, cpu, drive, gpu, network);
    }

    private static CpuInfo HandleCpuHardware(IHardware hardware)
    {
        var name = hardware.Name;
        var cores = 0;

        foreach (var sensor in hardware.Sensors)
        {
            switch (sensor.SensorType)
            {
                case SensorType.Load:
                    {
                        if (ContainsNumberRegex().IsMatch(sensor.Name))
                        {
                            if (sensor.Value.HasValue)
                            {
                                cores++;
                            }

                        }
                        break;
                    }
            }
        }
        return new CpuInfo(name, cores);

    }
    private static GpuInfo HandleGpuHardware(IHardware hardware)
    {
        var name = hardware.Name;
        var id = string.Empty;
        try
        {
            id = hardware.GetType().GetProperty("DeviceId")?.GetValue(hardware)?.ToString();

        }
        catch (Exception)
        {
            // ignored
        }
        return new GpuInfo(name, id ?? string.Empty);
    }
    private static List<InfoDrive> RetrieveDrivesInformation()
    {
        string[] possibleDrives = ["C:", "D:", "E:", "F:", "G:", "H:", "I:", "J:"];
        return possibleDrives.Select(RetrieveDriveInformation).OfType<InfoDrive>().ToList();
    }

    private static InfoDrive? RetrieveDriveInformation(string name)
    {
        try
        {
            var drive = new DriveInformation(name);
            return new InfoDrive(drive.Format, drive.Label, drive.Type, drive.RootDirectory);
        }
        catch (Exception)
        {
            // ignored

        }
        return null;
    }
    private static NetworkInfo? HandleNetworkHardware(IHardware hardware)
    {
        var networkInterface = (NetworkInterface?)GetSafeProperty(hardware, "NetworkInterface");
        if (networkInterface is null)
            return null;
        var name = hardware.Name;
        var description = networkInterface.Description;
        var isReceiveOnly = networkInterface.IsReceiveOnly;
        var interfaceType = networkInterface.NetworkInterfaceType.ToString();
        var supportMulticast =  networkInterface.SupportsMulticast;
        return new NetworkInfo(name, description ,isReceiveOnly, interfaceType, supportMulticast);
    }
    private static object? GetSafeProperty(object obj, string propertyName)
    {
        try
        {
            // Use BindingFlags to specify that you want to access non-public properties (private, protected, internal)
            var propertyInfo = obj.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        
            // If the property exists, get its value
            return propertyInfo?.GetValue(obj);
        }
        catch (Exception)
        {
            // ignored
            return null;
        }
    }
    private static BatteryInfo HandlePowerSupplyHardware(IHardware hardware)
    {
        var name = hardware.Name;
        var designedCapacity = GetSafeProperty(hardware, "DesignedCapacity")?.ToString() ?? string.Empty;
        var manufacturer = GetSafeProperty(hardware, "Manufacturer")?.ToString() ?? string.Empty;;
        var fullChargedCapacity = GetSafeProperty(hardware, "FullChargedCapacity")?.ToString() ?? string.Empty;
        var chemistry = GetSafeProperty(hardware, "Chemistry");
        var finalChemistry = string.Empty;
        if (chemistry is not null)
            finalChemistry = chemistry.ToString() ?? string.Empty;
        return new BatteryInfo(name, designedCapacity, manufacturer, fullChargedCapacity, finalChemistry);
    }

    private static void ReloadComputer()
    {
        _computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsStorageEnabled = true,
            IsNetworkEnabled = true,
            IsPsuEnabled = true
        };
        _computer.IsPsuEnabled = true;
        _computer.IsBatteryEnabled = true;
        _computer.Reset();
    }

    [GeneratedRegex(@"\d")]
    private static partial Regex ContainsNumberRegex();

}
