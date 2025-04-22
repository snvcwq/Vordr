namespace Vordr.Common.Messaging.Messages.HardwareReports;

public record RamReport
{
    public double AvailableMemory { get; init; }
    public double UsedMemory { get; init; }
    public DateTime CapturedAtUtc { get; init; }
};
