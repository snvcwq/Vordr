using Microsoft.Extensions.Options;
using Vordr.Client.WebApi.Interfaces;
using Vordr.Client.WebApi.Options;
using Vordr.Common.Enums;
using Vordr.Common.Messaging;
using Vordr.Common.Messaging.Messages.Registration;

namespace Vordr.Client.WebApi.Service;

public class RegistrationService(SocketClientService socketClientService, IOptions<RegistrationOptions> registrationOptions) : IRegistrationService
{
    public async Task<bool> RegisterApplication()
    {
        var regOpt = registrationOptions.Value;
        if (regOpt.IsRegistered)
            return true;
        var registration = new SocketMessage
        {
            Type = MessageType.Registration, ClientId = regOpt.ClientId, Payload = new RegistrationMessage(regOpt.ClientId, regOpt.HostName)
        };
        var response = await socketClientService.SendAsync(registration);
        var res = response?.Payload as RegistrationResponse;
        return res?.Successful is true;
    }

}
