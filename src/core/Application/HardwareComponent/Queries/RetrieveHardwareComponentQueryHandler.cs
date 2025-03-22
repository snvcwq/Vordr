using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.HardwareComponent.Queries;

public class RetrieveHardwareComponentQueryHandler(
    IHardwareComponentsRepository repository
    ) : IRequestHandler<RetrieveHardwareComponentQuery, HardwareComponents>
{

    public async Task<HardwareComponents> Handle(RetrieveHardwareComponentQuery request, CancellationToken cancellationToken)
    {
        return await repository.RetrieveAsync();
    }
}
