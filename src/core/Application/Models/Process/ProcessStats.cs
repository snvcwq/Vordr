namespace Vordr.Application.Models.Process;

public record ProcessStats
{
    public required double CpuUsage { get; set; }
        
    public required double RamUsage { get; set; }
        
    public int ThreadCount { get; set; }
        
    public int HandleCount { get; set; }
}
