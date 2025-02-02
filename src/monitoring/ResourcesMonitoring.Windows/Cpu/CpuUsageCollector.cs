using LibreHardwareMonitor.Hardware;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Models.Cpu;
using Vordr.ResourcesMonitoring.Windows.Ram;

namespace Vordr.ResourcesMonitoring.Windows.Cpu;

public class CpuUsageCollector : ICpuUsageCollector
{
    private static readonly Computer Computer = new()
    {
        IsCpuEnabled = true
    }; 
    
    public CpuLoadInformation Collect()
    {
        
        Computer.Open();
        Computer.Accept(new HardwareMonitorVisitor());
        double load = 0;
        double temperature = 0;
        double voltage = 0;
        
        var cpuHardware = Computer.Hardware.First(hardware => hardware.HardwareType == HardwareType.Cpu);
        foreach(var sensor in cpuHardware.Sensors)
        {
            
            switch (sensor.Name)
            {
                case CpuUsageConstants.TotalLoadSensor when sensor.SensorType is SensorType.Load:
                    load = sensor.Value.GetValueOrDefault();
                    break;
                case CpuUsageConstants.AverageTemperature when sensor.SensorType is SensorType.Temperature:
                    temperature = sensor.Value.GetValueOrDefault();
                    break;
                case CpuUsageConstants.AverageVoltage when sensor.SensorType is SensorType.Voltage:
                    voltage = sensor.Value.GetValueOrDefault();
                    break;
            }
        }
        Computer.Close();
        
        return new CpuLoadInformation
        {
            LoadPercents = Math.Round(load, RamUsageConstants.ValuesDecimalPlaces),
            Temperature = Math.Round(temperature, RamUsageConstants.ValuesDecimalPlaces),
            Voltage = Math.Round(voltage, RamUsageConstants.ValuesDecimalPlaces),
            CapturedAtUtc = DateTime.UtcNow
        };
    }
}
