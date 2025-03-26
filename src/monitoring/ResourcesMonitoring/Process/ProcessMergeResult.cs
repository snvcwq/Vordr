namespace Vordr.ResourcesMonitoring.Windows.Process;


public record ProcessMergeResult
{
    public int Pid { get; set; }
    
    public  string Name { get; set; } = string.Empty;

    public  DateTime StartTime { get; set; }
    
    public byte[]? Icon { get; set; }
    
    public  string Path { get; set; } = string.Empty;
    
    public  int Priority { get; set; }

    public  string Company { get; set; } = string.Empty;

    public  string Version { get; set; } = string.Empty;

    public  string Architecture { get; set; } = string.Empty;

    public  double CpuUsage { get; set; }
        
    public  double RamUsage { get; set; }
        
    public int ThreadCount { get; set; }
        
    public int HandleCount { get; set; }
}
