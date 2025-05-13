using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.Alert.Command;

public class UpdateAlertHandler(IAlertRepository repository) : IRequestHandler<UpdateAlertCommand>
{

    public async Task Handle(UpdateAlertCommand request, CancellationToken cancellationToken)
    {
        await repository.UpdateAsync(request.Alert);
    }
}
