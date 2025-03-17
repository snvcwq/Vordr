using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record PowerSupply : BaseMetric
{
    public required double DegradationLevel { get; init; }
    public required double ChargeLevel { get; init; }
}
