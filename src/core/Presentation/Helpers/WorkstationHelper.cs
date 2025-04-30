using Presentation.Options;
using System.Net;
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
        var address = socketOptions.LocalDeployment ? Dns.GetHostName() : socketOptions.DnsAddress;

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
}
