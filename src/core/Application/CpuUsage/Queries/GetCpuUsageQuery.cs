using Vordr.Domain.Entities;

namespace Vordr.Application.CpuUsage.Queries;

public record GetCpuUsageQuery : IRequest<IEnumerable<CpuLoad>>
{
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
}
