namespace Vordr.Application.Models.Ram;

public record RamUsageInformation
{
    public required double TotalMemory { get; set; } 
    public required double UsedMemory { get; set; } 
    public required DateTime CapturedAtUtc { get; set; } 
}
