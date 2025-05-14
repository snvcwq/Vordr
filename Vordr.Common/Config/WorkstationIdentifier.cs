namespace Vordr.Common.Config;

public class WorkstationIdentifier
{
    public required string ClientId { get; set; }
    public required string Address { get; set; }
    public int Port { get; set; }
    public string? HostName { get; set; }
}
