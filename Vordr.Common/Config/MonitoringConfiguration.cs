using Vordr.Common.Enums;

namespace Vordr.Common.Config;

public class MonitoringConfiguration
{
    public required MonitoringStatus MonitorProcesses { get; set; }
    
    public MonitoringStatus MonitorDrives { get; set; }
    
    public MonitoringStatus MonitorCpu { get; set; }
    
    public MonitoringStatus MonitorGpu { get; set; }
    
    public MonitoringStatus MonitorRam { get; set; }
    
    public MonitoringStatus MonitorStorageDevices { get; set; }
    
    public MonitoringStatus MonitorNetwork { get; set; }
    
    public MonitoringStatus MonitorPeripherals{ get; set; }
    
    public MonitoringStatus MonitorPowerSupply { get; set; }
    
}
