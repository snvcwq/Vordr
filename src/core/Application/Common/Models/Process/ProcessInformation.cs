namespace Vordr.Application.Common.Models.Process;

public record ProcessInformation
{
    public required int Pid { get; set; }
    
    public required string Name { get; set; }

    public required DateTime StartTime { get; set; }
    
    public byte[]? Icon { get; set; }
    
    public required string Path { get; set; }
    
    public required int Priority { get; set; }

    public required string Manufacturer { get; set; }

    public required string Version { get; set; }

    public required string Architecture { get; set; }

    public required string User { get; set; }

    public required double CpuUsage { get; set; }
        
    public required long RamUsage { get; set; }
        
    public required long MaxWorkingSet { get; set; }

    public double GpuUsage { get; set; }
        
    public int ThreadCount { get; set; }
        
    public int HandleCount { get; set; }

    public long DiskReadBytes { get; set; }
    
    public long DiskWriteBytes { get; set; }

    public long NetworkSentBytes { get; set; }
    
    public long NetworkReceivedBytes { get; set; }
}
