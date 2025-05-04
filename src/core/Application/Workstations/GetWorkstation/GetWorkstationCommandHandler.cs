using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.Workstations.GetWorkstation;

public class GetWorkstationCommandHandler(IWorkstationRepository repository) : IRequestHandler<GetWorkstationCommand, IEnumerable<Workstation>>
{

    public async Task<IEnumerable<Workstation>> Handle(GetWorkstationCommand request, CancellationToken cancellationToken)
    {
        return await repository.GetWorkstationAsync();
    }
}
