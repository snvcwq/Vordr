namespace Presentation.Options;

public class SocketOptions
{
    public int Port { get; set; } 
    public required string DnsAddress { get; set; } 
    public bool LocalDeployment { get; set; } 
}
