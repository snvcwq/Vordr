using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class PowerSupplyReportMappings
{
    public static PowerSupply ToPowerSupply(this PowerSupplyReport report) =>
        new()
        {
            ChargeLevel = report.ChargeLevel,
            DegradationLevel = report.DegradationLevel,
            CapturedAtUtc = report.CapturedAtUtc
        };
}
