using Microsoft.Extensions.DependencyInjection;
using Vordr.Client.Monitoring.Hardware;
using Vordr.Client.Monitoring.Interfaces.Resources;
using Vordr.Client.Monitoring.Process;
using HardwareComponentsCollector = Vordr.Client.Monitoring.Hardware.HardwareComponentsCollector;

namespace Vordr.Client.Monitoring;

public static class DependencyInjection
{
    public static IServiceCollection AddWindowsResourceCollectors(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped< IProcessDataCollector, ProcessDataCollector>();
        serviceCollection.AddScoped< IHardwareCollector, HardwareCollector>();
        serviceCollection.AddScoped< IHardwareComponentsCollector, HardwareComponentsCollector>();
        
        return serviceCollection;
    }
}
