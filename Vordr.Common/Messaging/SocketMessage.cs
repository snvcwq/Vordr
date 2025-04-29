using Vordr.Common.Enums;

namespace Vordr.Common.Messaging;

public class SocketMessage
{
    public required MessageType Type { get; set; }
    public required string ClientId { get; set; }
    public required object Payload { get; set; }
}
