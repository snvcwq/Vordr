
namespace Vordr.Client.Monitoring.Hardware.Metrics;

public class DriveInformation(string name)
{

    private DriveInfo Drive { get; set; } = new(name);
    
    public string Name => Drive.Name;
    public double TotalSize => Drive.TotalSize;
    public double FreeSpace => Drive.AvailableFreeSpace;
}
