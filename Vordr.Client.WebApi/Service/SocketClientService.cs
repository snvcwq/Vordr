using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Sockets;
using Vordr.Client.WebApi.Helpers;
using Vordr.Client.WebApi.Interfaces;
using Vordr.Client.WebApi.Options;
using Vordr.Common.Helpers;
using Vordr.Common.Messaging;

namespace Vordr.Client.WebApi.Service;

public class SocketClientService : IAsyncDisposable, ISocketClientService
{
    private readonly Socket _socket;

    public SocketClientService(IOptions<RegistrationOptions> options)
    {
        var config = options.Value;

        var ip = IPAddress.Parse(config.Address());
        var endPoint = new IPEndPoint(ip, config.Port());

        _socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        _socket.Connect(endPoint);
    }

    public async Task<SocketResponse?> SendAsync(object message)
    {
        await _socket.SendAsync(message.JsonSerialize().ToBytes(), SocketFlags.None);
        var buffer = new byte[1_024];

        var received = await _socket.ReceiveAsync(buffer, SocketFlags.None);
        var messageResponse = received.FromBytes(buffer).JsonDeserialize<SocketResponse>();
        return messageResponse;
    }

    public ValueTask DisposeAsync()
    {
        _socket.Shutdown(SocketShutdown.Both);
        _socket.Close();
        _socket.Dispose();
        return ValueTask.CompletedTask;
    }
}
