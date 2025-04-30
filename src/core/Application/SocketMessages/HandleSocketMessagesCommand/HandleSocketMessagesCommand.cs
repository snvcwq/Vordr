using Vordr.Common.Messaging;

namespace Vordr.Application.SocketMessages.HandleSocketMessagesCommand;

public record HandleSocketMessagesCommand(SocketMessage Message) : IRequest<SocketResponse>;
