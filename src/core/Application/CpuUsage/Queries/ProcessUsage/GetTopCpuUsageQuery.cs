using Vordr.Application.Models;

namespace Vordr.Application.CpuUsage.Queries.ProcessUsage;

public record GetTopCpuUsageQuery : IRequest<IEnumerable<TopCpu>>
{
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public string? ClientId { get; set; }
}
