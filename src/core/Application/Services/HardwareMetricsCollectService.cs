using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Common.Mappings.HardwareMetrics;
using Vordr.Application.Models.Hardware;
using Vordr.Domain.Entities;

namespace Vordr.Application.Services;

public class HardwareMetricsCollectService(
    IHardwareCollector collector,
    IMediator mediator,
    IMonitoringConfigurationRepository monitoringConfigurationRepository,
    ILogger<HardwareMetricsCollectService> logger
    ) : IHardwareMetricsCollectService
{
    public async Task<HardwareReport?> CollectHardwareAsync(CancellationToken cancellationToken)
    {

        var monitoringConfigResult = await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigResult.Match(
            suc =>
            {
                logger.LogDebug(
                    "Monitoring configuration was successfully retrieved for configuring hardware monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError(
                    "Error occured when retrieving monitoring configuration for configuring hardware monitoring. Errors:{errors} .",
                    errors.Print());
                return (MonitoringConfiguration?)null;
            });

        if (monitoringConfiguration is null)
        {
            logger.LogWarning(
                "Monitoring configuration was not retrieved. cpu load monitoring configuration will not be performed.");
            return null;
        }
        
        var information = collector.Collect(monitoringConfiguration);
        await mediator.Send(information.ToUploadHardwareMetricsCommand(), cancellationToken);
        return information;
    }
}
