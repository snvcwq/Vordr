using System.Text;
using System.Text.Json;
using Vordr.Common.Config;

namespace Vordr.Client.WebApi.Options;

public class RegistrationOptions
{
    public required bool IsRegistered { get; init; }
    public required string Identifier { get; init; }

    public int Port()
    {
        var decodedBytes = Convert.FromBase64String(Identifier);
        var jsonString = Encoding.UTF8.GetString(decodedBytes);
        var port =JsonSerializer.Deserialize<WorkstationIdentifier>(jsonString)?.Port;
        return port ?? 5060;
    }

    public string Address()
    {
        var decodedBytes = Convert.FromBase64String(Identifier);
        var jsonString = Encoding.UTF8.GetString(decodedBytes);

       var address= JsonSerializer.Deserialize<WorkstationIdentifier>(jsonString)?.Address;
        return address ?? string.Empty;
    }

    public string ClientId()
    {
        var decodedBytes = Convert.FromBase64String(Identifier);
        var jsonString = Encoding.UTF8.GetString(decodedBytes);
        var client =JsonSerializer.Deserialize<WorkstationIdentifier>
                (jsonString)?
            .ClientId;
        return client ?? string.Empty;

    }
}
