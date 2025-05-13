using Vordr.Application.Models;
using Vordr.Domain.Entities;
using Vordr.Domain.Entities.Components;

namespace Vordr.Application.Battery.Queries;

public record GetBatteryUsageQuery : IRequest<IEnumerable<PowerSupply>>
{
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public required string ClientId { get; init; }
}
