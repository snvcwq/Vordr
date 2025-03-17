using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class GpuReportMappings
{
    public static GpuLoad ToGpuLoad(this GpuReport report) =>
        new()
        {
            LoadPercentage = report.AvgLoad,
            Clock = report.Clock,
            Temperature = report.Temperature,
            CapturedAtUtc = report.CapturedAtUtc
        };
}
