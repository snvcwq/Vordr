using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record GpuLoad : BaseMetric
{
    public required double LoadPercentage { get; init; }
    public required double Temperature { get; init; }
    public required double Clock { get; init; }
}
