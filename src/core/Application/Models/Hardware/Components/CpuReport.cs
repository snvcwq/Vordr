namespace Vordr.Application.Models.Hardware.Components;

public record CpuReport
{
    public double AvgUsage { get; init; }
    public double Temperature { get; init; }
    public System.DateTime CapturedAtUtc { get; init; }
};
