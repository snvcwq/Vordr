using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.HardwareComponent.Queries.RetrieveAsync;

public class RetrieveHardwareComponentQueryHandlerAsync(
    IHardwareComponentsRepository repository
    ) : IRequestHandler<RetrieveHardwareComponentQueryAsync, HardwareComponents>
{

    public async Task<HardwareComponents> Handle(RetrieveHardwareComponentQueryAsync request, CancellationToken cancellationToken)
    {
        return await repository.RetrieveAsync();
    }
}
