using System.Net;
using System.Net.Sockets;

namespace Presentation.Socket;

public class SocketSettings
{
    /// <summary>
    /// Creates Socket with generic settings
    /// </summary>
    /// <returns>Created Socket and IPEndPoint of socket</returns>
    public async Task<(System.Net.Sockets.Socket, IPEndPoint)> CreateSocket(int port, string hostName)
    {
        var ipEndPoint = await CreateDefaultIpEndpoint(port, hostName);
        return (new System.Net.Sockets.Socket(
            ipEndPoint.AddressFamily,
            SocketType.Stream,
            ProtocolType.Tcp
        ), ipEndPoint);
    }

    private async Task<IPEndPoint> CreateDefaultIpEndpoint(int port, string hostName)
    {
        var ipEntry = await Dns.GetHostEntryAsync(hostName);
        var ip = ipEntry.AddressList.FirstOrDefault();
        if (ip is null)
            throw new Exception("IP Address is null");

        return new IPEndPoint(ip, port);
    }
}
