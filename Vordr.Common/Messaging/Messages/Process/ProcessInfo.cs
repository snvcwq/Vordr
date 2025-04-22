namespace Vordr.Common.Messaging.Messages.Process;

public record ProcessInfo
{
    public required int Pid { get; set; }
    
    public required string Name { get; set; }

    public required DateTime StartTime { get; set; }
    
    public byte[]? Icon { get; set; }
    
    public required string Path { get; set; }
    
    public required int Priority { get; set; }

    public required string Company { get; set; }

    public required string Version { get; set; }

    public required string Architecture { get; set; }

    public required double CpuUsage { get; set; }
        
    public required double RamUsage { get; set; }
    public required bool IsSystemProcess { get; set; }
        
    public int ThreadCount { get; set; }
        
    public int HandleCount { get; set; }
}
