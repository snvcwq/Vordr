using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.Workstations.DeleteWorkstation;

public class DeleteWorkstationCommandHandler(IWorkstationRepository repository) : IRequestHandler<DeleteWorkstationCommand>
{

    public async Task Handle(DeleteWorkstationCommand request, CancellationToken cancellationToken)
    {
        await repository.RemoveWorkstationAsync(request.ClientId);
    }
}
