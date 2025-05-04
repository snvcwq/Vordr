using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.HardwareComponent.Commands;

public class UpdateHardwareComponentCommandHandler(
    IHardwareComponentsRepository repository
    ) : IRequestHandler<UpdateHardwareComponentCommand>
{

    public async Task Handle(UpdateHardwareComponentCommand request, CancellationToken cancellationToken)
    {
        await repository.UploadAsync(request.components, request.clientId);
    }
}
