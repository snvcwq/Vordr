using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.Alert.Query.Get;

public class GetAllAlertsCommandHandler(IAlertRepository repository) : IRequestHandler<GetAllAlertsCommand, List<Domain.Entities.Alert>>
{

    public async Task<List<Domain.Entities.Alert>> Handle(GetAllAlertsCommand request, CancellationToken cancellationToken)
    {
        var alerts = await repository.GetAllAsync();
        return alerts.ToList();
    }
}
