using Vordr.Domain.Entities;

namespace Vordr.Application.Ram.Queries.Get;

public record GetRamUsageQuery : IRequest<IEnumerable<RamUsage>>
{
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
}
