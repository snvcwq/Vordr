namespace Vordr.Common.Messaging;

public class SocketMessage
{
    public required SocketMessage Type { get; set; }
    public required string ClientId { get; set; }
    public required object Payload { get; set; }
}
