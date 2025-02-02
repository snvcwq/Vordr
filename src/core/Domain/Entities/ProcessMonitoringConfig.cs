using Vordr.Domain.Enums;

namespace Vordr.Domain.Entities;

public record ProcessMonitoringConfig
{
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitoringStatus { get; set; }
    
    public required string ScanFrequency { get; set; }
    
    public required int MaxProcessesToScan { get; set; }

    public List<string> ExcludedProcesses { get; set; } = [];

}
