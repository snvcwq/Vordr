namespace Vordr.Application.RamUsage.Commands.Upload;

public record UploadCollectedRamUsageCommand : IRequest
{
    public required double TotalMemory { get; set; } 
    public required double UsedMemory { get; set; } 
    public required DateTime CapturedAtUtc { get; set; } 
}
