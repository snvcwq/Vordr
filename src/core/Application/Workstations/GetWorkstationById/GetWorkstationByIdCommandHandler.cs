using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.Workstations.GetWorkstationById;

public class GetWorkstationCommandHandlerById(IWorkstationRepository repository) : IRequestHandler<GetWorkstationByIdCommand, Workstation?>
{
    public async Task<Workstation?> Handle(GetWorkstationByIdCommand request, CancellationToken  cancellationToken)
    {
        return await repository.GetWorkstationAsync(request.ClientId);
    }
}
