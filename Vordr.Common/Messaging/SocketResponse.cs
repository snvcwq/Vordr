using Vordr.Common.Enums;

namespace Vordr.Common.Messaging;

public record SocketResponse(MessageType Type, object? Payload);
