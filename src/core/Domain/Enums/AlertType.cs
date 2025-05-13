namespace Vordr.Domain.Enums;

public enum AlertType
{
    ComputerDisconnected,
    GpuIsMoreThan,
    GpuTempIsMoreThan,
    CpuIsMoreThan,
    CpuTempIsMoreThan,
    RamIsMoreThan,
    DriveIsMoreThan,
    BatteryLevelIsLessThan,
    BatteryDegradationLevelIsLessThan,
    ProcessUsesRamMoreThan,
    ProcessUsesCpuMoreThan
}
