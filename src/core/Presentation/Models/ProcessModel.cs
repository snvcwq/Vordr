namespace Presentation.Models;

public class ProcessModel
{
    public required int Pid { get; set; }
    public byte[]? Icon { get; set; }

    public required string Name { get; set; }

    public required DateTime StartTime { get; set; }
    
    public required string Path { get; set; }
    
    public required int Priority { get; set; }

    public required string Manufacturer { get; set; }

    public required string Version { get; set; }

    public required string Architecture { get; set; }
    
    public required double Cpu { get; set; }
        
    public required double Ram { get; set; }
        
    public int Threads { get; set; }
        
    public int Handles { get; set; }
    public bool System { get; set; }
}
