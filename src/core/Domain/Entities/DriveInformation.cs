using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record DriveInformation : BaseMetric
{
    public required string DriveName { get; set; }
    public required double DriveFreeSpaceGb { get; set; }
    public required double DriveTotalSizeGb { get; set; }
}
