namespace Vordr.Common.Messaging.Messages.HardwareReports;

public record GpuReport
{
    public double AvgLoad { get; init; }
    public double Temperature { get; init; }
    public double Clock { get; init; }
    public System.DateTime CapturedAtUtc { get; init; }
};
