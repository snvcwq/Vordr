using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record RamUsage : BaseMetric
{
    public required double AvailableMemory { get; set; } 
    public required double UsedMemory { get; set; } 
}
