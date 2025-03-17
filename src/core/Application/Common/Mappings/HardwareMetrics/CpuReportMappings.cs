using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class CpuReportMappings
{
    public static CpuLoad ToCpuLoad(this CpuReport report) =>
        new()
        {
            LoadPercents = report.AvgUsage,
            Temperature = report.Temperature,
            CapturedAtUtc = report.CapturedAtUtc
        };
}
