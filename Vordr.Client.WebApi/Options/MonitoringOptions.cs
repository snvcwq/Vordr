namespace Vordr.Client.WebApi.Options;

public record MonitoringOptions
{
    public string HardwareComponentsFrequencyCronExpression { get; init; } = string.Empty;
    public string HardwareDataFrequencyCronExpression { get; init; } = string.Empty;
    public string HardwareProcessFrequencyCronExpression { get; init; } = string.Empty;
}
