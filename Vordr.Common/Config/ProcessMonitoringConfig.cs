using Vordr.Common.Enums;

namespace Vordr.Common.Config;

public record ProcessMonitoringConfig
{
    public MonitoringStatus MonitoringStatus { get; set; }
    
    public required string ScanFrequency { get; set; }
    
}
