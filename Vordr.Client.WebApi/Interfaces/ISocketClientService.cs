using Vordr.Common.Messaging;

namespace Vordr.Client.WebApi.Interfaces;

public interface ISocketClientService
{
    public Task<SocketResponse?> SendAsync(object message);

}
