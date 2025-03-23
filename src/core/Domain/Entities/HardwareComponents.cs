using Vordr.Domain.Common;
using Vordr.Domain.Entities.Components;

namespace Vordr.Domain.Entities;

public record HardwareComponents(
    BatteryInfo Battery,
    CpuInfo Cpu,
    IEnumerable<InfoDrive> Drives,
    IEnumerable<GpuInfo> Gpu,
    IEnumerable<NetworkInfo> Network
    ) : BaseEntity;
