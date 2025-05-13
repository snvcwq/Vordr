using Vordr.Common.Messaging.Messages.HardwareComponents.Components;

namespace Vordr.Common.Messaging.Messages.HardwareComponents;

public class HardwareData
{
    public HardwareData(BatteryInfo battery, CpuInfo cpu, IEnumerable<InfoDrive> drives, IEnumerable<GpuInfo> gpu, IEnumerable<NetworkInfo> network)
    {
        Battery = battery;
        Cpu = cpu;
        Drives = drives;
        Gpu = gpu;
        Network = network;
    }
    public BatteryInfo Battery { get; set; }
    public CpuInfo Cpu { get; set; }
    public IEnumerable<InfoDrive> Drives { get; set; }
        public IEnumerable<GpuInfo> Gpu { get; set; }
        public   IEnumerable<NetworkInfo> Network  { get; set; } 
}

    
