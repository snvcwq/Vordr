namespace Vordr.Common.Messaging.Messages.HardwareReports;

public class HardwareReport
{
    public CpuReport? Cpu { get; set; }
    public List<DriveReport> Drives { get; set; } = [];
    public GpuReport? Gpu { get; set; }
    public List<NetworkReport> Networks { get; set; } = [];
    public RamReport? Ram { get; set; }
    public PowerSupplyReport? Battery { get; set; }
}
