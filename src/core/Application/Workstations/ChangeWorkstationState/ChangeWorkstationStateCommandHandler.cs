using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.Workstations.ChangeWorkstationState;

public class ChangeWorkstationStateCommandHandler(IWorkstationRepository repository) : IRequestHandler<ChangeWorkstationStateCommand, bool>
{

    public async Task<bool> Handle(ChangeWorkstationStateCommand request, CancellationToken cancellationToken)
    {
        return await repository.ChangeMonitoringStateAsync(request.ClientId, request.State);
    }
}
