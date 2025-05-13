namespace Vordr.Application.Notfication.SendNotfication;

public record SendNotificationCommand(string Message) : IRequest;
