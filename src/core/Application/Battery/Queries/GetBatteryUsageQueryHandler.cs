using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.Battery.Queries;

public class GetBatteryUsageQueryHandler(IPowerSupplyRepository repository) : IRequestHandler<GetBatteryUsageQuery, IEnumerable<PowerSupply>>
{

    public Task<IEnumerable<PowerSupply>> Handle(GetBatteryUsageQuery request, CancellationToken cancellationToken)
    {
        return repository.Retrieve(request);
    }
}
