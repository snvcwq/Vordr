using Vordr.Domain.Enums;

namespace Vordr.Application.Notfication.SendNotfication;

public record SendNotificationCommand(string Message, AlertType AlertType) : IRequest;
