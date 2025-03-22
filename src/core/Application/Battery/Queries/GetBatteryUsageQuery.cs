using Vordr.Application.Models;
using Vordr.Domain.Entities;

namespace Vordr.Application.Battery.Queries;

public record GetBatteryUsageQuery : IRequest<IEnumerable<PowerSupply>>
{
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public required DayTime StartHour { get; init; }
    public required DayTime EndHour { get; init; }
};
