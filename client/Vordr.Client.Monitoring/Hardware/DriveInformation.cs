namespace Vordr.Client.Monitoring.Hardware;

public class DriveInformation(string name)
{

    private DriveInfo Drive { get; set; } = new(name);
    
    public string Name => Drive.Name;
    public double TotalSize => Drive.TotalSize;
    public double FreeSpace => Drive.AvailableFreeSpace;
    public string Format => Drive.DriveFormat;
    public string Label => Drive.VolumeLabel;
    public string Type => Drive.DriveType.ToString();
    public string RootDirectory => Drive.RootDirectory.FullName;
}
