using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Resources;

namespace Vordr.Application.HardwareComponent.Commands;

public class UpdateHardwareComponentCommandHandler(
    IHardwareComponentsCollector collector,
    IHardwareComponentsRepository repository
    ) : IRequestHandler<UpdateHardwareComponent>
{

    public async Task Handle(UpdateHardwareComponent request, CancellationToken cancellationToken)
    {
        var components = collector.Collect();
        await repository.UploadAsync(components);
    }
}
