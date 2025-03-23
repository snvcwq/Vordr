namespace Vordr.Application.Models;

public class TopCpu
{
    public DateTime Time { get; set; }
    public required string Name { get; set; }
    public double Load {get; set;}
}
