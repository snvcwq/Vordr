namespace Vordr.Application.Models.Cpu;

public record CpuLoadInformation
{
    public required double LoadPercents { get; set; }
    public required double Temperature { get; set; }
    public required double Voltage { get; set; }
    public required DateTime CapturedAtUtc { get; set; }
}
