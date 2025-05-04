using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.Workstations.AddWorkstation;

public class AddWorkstationCommandHandler(IWorkstationRepository repository) : IRequestHandler<AddWorkstationCommand>
{

    public async Task Handle(AddWorkstationCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateWorkstationAsync(request.Workstation);
    }
}
