using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.Alert.Query.Get;

public class GetAlertByTypeCommandHandler(IAlertRepository repository) : IRequestHandler<GetAlertByTypeCommand, Domain.Entities.Alert>
{

    public async Task<Domain.Entities.Alert> Handle(GetAlertByTypeCommand request, CancellationToken cancellationToken)
    {
        return await repository.GetByTypeAsync(request.Type);
    }
}
