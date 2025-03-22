namespace Vordr.Application.Models.Hardware.Components;

public record PowerSupplyReport
{
    public double DegradationLevel { get; init; }
    public double ChargeLevel { get; init; }
    public System.DateTime CapturedAtUtc { get; init; }
}
