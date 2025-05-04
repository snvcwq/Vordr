using System.Text.Json;
using Vordr.Common.Config;

namespace Vordr.Client.WebApi.Options;

public class RegistrationOptions
{
    public required bool IsRegistered { get; init; }
    public required string Identifier { get; init; }

    public int Port()
    {
        var port =JsonSerializer.Deserialize<WorkstationIdentifier>(Identifier)?.Port;
        return port ?? 5060;
    }

    public string Address()
    {
       var address= JsonSerializer.Deserialize<WorkstationIdentifier>(Identifier)?.Address;
        return address ?? string.Empty;
    }

    public string ClientId()
    {
        var client =JsonSerializer.Deserialize<WorkstationIdentifier>
                (Identifier)?
            .ClientId;
        return client ?? string.Empty;

    }
}
