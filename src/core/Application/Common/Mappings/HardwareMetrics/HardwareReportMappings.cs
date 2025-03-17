using Vordr.Application.Hardware.Commands.UploadHardwareMetrics;
using Vordr.Application.Models.Hardware;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class HardwareReportMappings
{
    public static UploadHardwareMetricsCommand ToUploadHardwareMetricsCommand(this HardwareReport report) =>
        new(report);
}
