using Vordr.Common.Messaging.Messages.Registration;

namespace Vordr.Application.SocketMessages.HandleClientRegistrationCommand;

public record HandleClientRegistrationCommand(RegistrationMessage message) : IRequest<RegistrationResponse>
{
    
}
