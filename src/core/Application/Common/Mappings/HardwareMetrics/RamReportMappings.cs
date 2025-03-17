using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class RamReportMappings
{
    public static RamUsage ToRamUsage(this RamReport report) =>
        new()
        {
            AvailableMemory = report.AvailableMemory,
            UsedMemory = report.UsedMemory,
            CapturedAtUtc = report.CapturedAtUtc
        };
}
