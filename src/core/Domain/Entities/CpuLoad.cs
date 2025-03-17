using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record CpuLoad : BaseMetric
{
    public required double LoadPercents { get; set; } 
    
    public required double Temperature { get; set; }
}
