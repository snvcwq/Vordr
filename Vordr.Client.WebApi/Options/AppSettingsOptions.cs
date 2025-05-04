using Vordr.Common.Config;

namespace Vordr.Client.WebApi.Options;

public class AppSettingsOptions
{
    public MonitoringOptions? MonitoringOptions { get; set; }
    public RegistrationOptions? RegistrationOptions { get; set; }
    public MonitoringConfiguration? MonitoringConfiguration{ get; set; }
    
}
