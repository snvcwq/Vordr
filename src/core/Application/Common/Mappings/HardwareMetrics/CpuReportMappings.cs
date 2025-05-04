using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class CpuReportMappings
{
    public static CpuLoad ToCpuLoad(this CpuReport report, string clientId) =>
        new()
        {
            LoadPercents = report.AvgUsage,
            Temperature = report.Temperature,
            CapturedAtUtc = report.CapturedAtUtc,
            ClientId = clientId
        };
}
