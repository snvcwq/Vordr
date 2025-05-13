using Vordr.Domain.Entities;

namespace Vordr.Application.GpuUsage.Get;

public record GetGpuUsageQuery : IRequest<IEnumerable<GpuLoad>>
{
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public required string ClientId { get; init; }

}
