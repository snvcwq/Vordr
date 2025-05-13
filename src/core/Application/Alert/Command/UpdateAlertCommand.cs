namespace Vordr.Application.Alert.Command;

public class UpdateAlertCommand(Domain.Entities.Alert alert) : IRequest
{
    public Domain.Entities.Alert Alert { get; } = alert;

}
