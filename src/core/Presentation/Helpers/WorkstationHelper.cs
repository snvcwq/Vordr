using Presentation.Options;
using System.Net;
using System.Net.Sockets;
using Vordr.Common.Config;
using Vordr.Common.Helpers;

namespace Presentation.Helpers;

public static class WorkstationHelper
{
    public static string CreateNewClientId()
    {
        return Guid.NewGuid().ToString();
    }

    public static string CreateNewWorkstationIdentifier(SocketOptions socketOptions, string clientId)
    {
        var address = GetHostIp(socketOptions);

        var workstationIdentifier = new WorkstationIdentifier
        {
            ClientId = clientId,
            Address = address,
            Port = socketOptions.Port
        };

        var bytes = workstationIdentifier.JsonSerialize().ToBytes();
        var base64 = Convert.ToBase64String(bytes);
        return base64;
    }

    public static async Task<string> GetLocalHostIpAsync()
    {
        var hostEntry = await Dns.GetHostEntryAsync(Dns.GetHostName());
        var localIP = hostEntry.AddressList.FirstOrDefault(ip => 
            ip.AddressFamily == AddressFamily.InterNetwork && !IPAddress.IsLoopback(ip));
        return localIP!.ToString();
    }
    
    public static string GetLocalHostIp()
    {
        var hostEntry = Dns.GetHostEntry(Dns.GetHostName());
        var localIP = hostEntry.AddressList.FirstOrDefault(ip => 
            ip.AddressFamily == AddressFamily.InterNetwork && !IPAddress.IsLoopback(ip));
        return localIP!.ToString();
    }
    
    public static async Task<string> GetHostIpAsync(SocketOptions socketOptions)
    {
       return socketOptions.LocalDeployment ? await GetLocalHostIpAsync() : socketOptions.DnsAddress;

    }
    
    public static string GetHostIp(SocketOptions socketOptions)
    {
        return socketOptions.LocalDeployment ? GetLocalHostIp() : socketOptions.DnsAddress;

    }
}
