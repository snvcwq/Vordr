namespace Vordr.Application.Models.Hardware.Components;

public record RamReport
{
    public double AvailableMemory { get; init; }
    public double UsedMemory { get; init; }
    public DateTime CapturedAtUtc { get; init; }
};
