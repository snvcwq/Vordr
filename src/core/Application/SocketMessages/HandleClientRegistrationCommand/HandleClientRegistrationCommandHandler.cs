using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Common.Messaging.Messages.Registration;

namespace Vordr.Application.SocketMessages.HandleClientRegistrationCommand;

public class HandleClientRegistrationCommandHandler(IWorkstationRepository workstationRepository) : IRequestHandler<HandleClientRegistrationCommand, RegistrationResponse>
{

    public async Task<RegistrationResponse> Handle(HandleClientRegistrationCommand request, CancellationToken cancellationToken)
    {
        var result = await workstationRepository.RegisterWorkstationAsync(request.message.ClientId, request.message.HostName);
        return new RegistrationResponse(result);
    }
}
