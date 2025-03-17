using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class DriveReportMappings
{
    public static DriveInformation ToDriveInformation(this DriveReport report) =>
        new()
        {
            DriveName = report.DriveName,
            DriveFreeSpaceGb = report.DriveFreeSpace,
            DriveTotalSizeGb = report.DriveTotalSize
        };
}
