using LibreHardwareMonitor.Hardware;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Models.Ram;

namespace Vordr.ResourcesMonitoring.Windows.Ram;

public class RamUsageCollector : IRamUsageCollector
{
    private static readonly Computer Computer = new()
    {
        IsMemoryEnabled = true
    }; 
    
    public RamUsageInformation Collect()
    {
        double availableMemory = 0;
        double usedMemory = 0;
        
        Computer.Open();
        Computer.Accept(new HardwareMonitorVisitor());
        
        var memoryHardwareModules = Computer.Hardware.Where(hardware => hardware.HardwareType == HardwareType.Memory);
        foreach (var hardware in memoryHardwareModules)
        {
            foreach (var sensor in hardware.Sensors)
            {
                switch (sensor.Name)
                {
                    case RamUsageConstants.MemoryAvailableSensor:
                        availableMemory += sensor.Value.GetValueOrDefault();
                        break;
                    case RamUsageConstants.MemoryUsedSensor:
                        usedMemory += sensor.Value.GetValueOrDefault();
                        break;
                }
            }

        }
        Computer.Close();
        
        return new RamUsageInformation
        {
            TotalMemory = Math.Round(availableMemory + usedMemory, RamUsageConstants.ValuesDecimalPlaces),
            UsedMemory = Math.Round(usedMemory, RamUsageConstants.ValuesDecimalPlaces),
            CapturedAtUtc = DateTime.UtcNow
        };
    }
}
