using Vordr.Common.Messaging.Messages.HardwareComponents.Components;

namespace Vordr.Common.Messaging.Messages.HardwareComponents;

public record HardwareData(
    BatteryInfo Battery,
    CpuInfo Cpu,
    IEnumerable<InfoDrive> Drives,
    IEnumerable<GpuInfo> Gpu,
    IEnumerable<NetworkInfo> Network);
