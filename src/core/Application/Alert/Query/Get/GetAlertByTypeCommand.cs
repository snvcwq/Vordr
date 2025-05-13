using Vordr.Domain.Enums;

namespace Vordr.Application.Alert.Query.Get;

public class GetAlertByTypeCommand(AlertType type) : IRequest<Domain.Entities.Alert>
{
    public AlertType Type { get; } = type;

}
