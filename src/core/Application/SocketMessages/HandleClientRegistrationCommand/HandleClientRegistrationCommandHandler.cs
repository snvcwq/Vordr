using Vordr.Common.Messaging.Messages.Registration;

namespace Vordr.Application.SocketMessages.HandleClientRegistrationCommand;

public class HandleClientRegistrationCommandHandler : IRequestHandler<HandleClientRegistrationCommand, RegistrationResponse>
{

    public Task<RegistrationResponse> Handle(HandleClientRegistrationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
