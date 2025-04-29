using Microsoft.Extensions.Options;
using Vordr.Client.Monitoring.Interfaces.Resources;
using Vordr.Client.WebApi.Interfaces;
using Vordr.Client.WebApi.Options;
using Vordr.Common.Config;
using Vordr.Common.Enums;
using Vordr.Common.Messaging;

namespace Vordr.Client.WebApi.Service;

public class MonitoringService(
    ISocketClientService socketClientService,
    IHardwareCollector hardwareCollector,
    IHardwareComponentsCollector hardwareComponentsCollector,
    IProcessDataCollector processDataCollector,
    IOptionsMonitor<RegistrationOptions> registrationOptions,
    IOptionsMonitor<MonitoringConfiguration> monitoringConfOptions 
    ) : IMonitoringService
{
    public async Task PerformHardwareComponentMonitoring()
    {
        var data = hardwareComponentsCollector.Collect();
        var msg = CreateSocketMessage(MessageType.HardwareComponents, data);
        await socketClientService.SendAsync(msg);
    }
    public async Task PerformHardwareDataMonitoring()
    {
        var monitoringConf = monitoringConfOptions.CurrentValue;
        var data = hardwareCollector.Collect(monitoringConf);
        var msg = CreateSocketMessage(MessageType.HardwareData, data);
        await socketClientService.SendAsync(msg);
    }
    public async Task PerformProcessesMonitoring()
    {
        var data = await processDataCollector.GetCurrentProcesses();
        var msg = CreateSocketMessage(MessageType.ProcessList, data);
        await socketClientService.SendAsync(msg);
    }

    private SocketMessage CreateSocketMessage(MessageType messageType, object payload)
    {
        var regOptions = registrationOptions.CurrentValue;
        return new SocketMessage
        {
            Type = messageType,
            ClientId = regOptions.ClientId,
            Payload = payload 
        };    
    }
}
