using Vordr.Domain.Common;
using Vordr.Domain.Enums;

namespace Vordr.Domain.Entities;

public record MonitoringConfiguration : BaseEntity
{
    public const string CollectionName = "monitoringConfiguration";
    
    public required ProcessMonitoringConfig ProcessMonitoringConfig { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorDrives { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorCpu { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorGpu { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorRam { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorStorageDevices { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorMotherBoard { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorNetwork { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorPeripherals{ get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorTemperature { get; set; }
    
    [BsonRepresentation(BsonType.String)]
    public MonitoringStatus MonitorPowerSupply { get; set; }
}
