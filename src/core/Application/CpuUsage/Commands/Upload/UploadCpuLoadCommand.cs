namespace Vordr.Application.CpuUsage.Commands.Upload;

public record UploadCpuLoadCommand : IRequest
{
    public required double LoadPercents { get; set; }
    
    public required double Temperature { get; set; }
    
    public required double Voltage { get; set; }
    
    public required DateTime CapturedAtUtc { get; set; }
}
