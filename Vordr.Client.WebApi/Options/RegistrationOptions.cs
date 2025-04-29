namespace Vordr.Client.WebApi.Options;

public record RegistrationOptions
{
    public required bool IsRegistered { get; init; }
    public required string HostName { get; init; }
    public required string ClientId { get; init; }
    public required string Address { get; init; }
    public int Port { get; init; }
}
