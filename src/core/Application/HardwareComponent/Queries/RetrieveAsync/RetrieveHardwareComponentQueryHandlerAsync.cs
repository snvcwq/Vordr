using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.HardwareComponent.Queries.RetrieveAsync;

public class RetrieveHardwareComponentQueryHandler(
    IHardwareComponentsRepository repository
    ) : IRequestHandler<RetrieveHardwareComponentQuery, HardwareComponents>
{

    public Task<HardwareComponents> Handle(RetrieveHardwareComponentQuery request, CancellationToken cancellationToken)
    {
        var x = repository.Retrieve();
        return Task.FromResult(x);
    }
}
