namespace Vordr.Common.Messaging.Messages.HardwareReports;

public record PowerSupplyReport
{
    public double DegradationLevel { get; init; }
    public double ChargeLevel { get; init; }
    public System.DateTime CapturedAtUtc { get; init; }
}
