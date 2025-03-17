using Vordr.Application.Models.Hardware.Components;

namespace Vordr.Application.Models.Hardware;

public record HardwareReport
{
    public CpuReport? Cpu { get; set; }
    public List<DriveReport> Drives { get; set; } = [];
    public GpuReport? Gpu { get; set; }
    public List<NetworkReport> Networks { get; set; } = [];
    public RamReport? Ram { get; set; }
    public PowerSupplyReport? Battery { get; set; }
}
