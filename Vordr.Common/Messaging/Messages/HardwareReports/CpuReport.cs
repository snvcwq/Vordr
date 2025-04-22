namespace Vordr.Common.Messaging.Messages.HardwareReports;

public record CpuReport
{
    public double AvgUsage { get; init; }
    public double Temperature { get; init; }
    public System.DateTime CapturedAtUtc { get; init; }
};
