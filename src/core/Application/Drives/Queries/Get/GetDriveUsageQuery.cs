using Vordr.Domain.Entities;

namespace Vordr.Application.Drives.Queries.Get;

public record GetDriveUsageQuery : IRequest<IEnumerable<DriveInformation>>
{
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
}
