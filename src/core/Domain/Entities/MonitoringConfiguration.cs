using Vordr.Domain.Common;
using Vordr.Domain.Enums;

namespace Vordr.Domain.Entities;

public record MonitoringConfiguration : BaseEntity
{
    public MonitoringStatus MonitoringStatus { get; set; }
    
}
