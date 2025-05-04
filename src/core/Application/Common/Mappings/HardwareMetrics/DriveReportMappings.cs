using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class DriveReportMappings
{
    public static DriveInformation ToDriveInformation(this DriveReport report, string clientId) =>
        new()
        {
            DriveName = report.DriveName,
            DriveFreeSpaceGb = report.DriveFreeSpace,
            DriveTotalSizeGb = report.DriveTotalSize,
            ClientId = clientId
        };
}
