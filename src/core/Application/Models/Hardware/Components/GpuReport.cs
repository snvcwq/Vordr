namespace Vordr.Application.Models.Hardware.Components;

public record GpuReport
{
    public double AvgLoad { get; init; }
    public double Temperature { get; init; }
    public double Clock { get; init; }
    public DateTime CapturedAtUtc { get; init; }
};
