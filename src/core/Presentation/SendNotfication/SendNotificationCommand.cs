using ErrorOr;
using MediatR;

namespace Presentation.SendNotfication;

public record SendNotificationCommand(string Message) : IRequest<ErrorOr<Success>>;
