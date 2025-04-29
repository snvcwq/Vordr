namespace Vordr.Common.Messaging.Messages.Registration;

public record RegistrationMessage(string ClientId, string? HostName)
{
}
