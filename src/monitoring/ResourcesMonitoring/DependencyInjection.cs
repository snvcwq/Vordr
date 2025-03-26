using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.ResourcesMonitoring.Windows.Hardware;
using Vordr.ResourcesMonitoring.Windows.Process;

namespace Vordr.ResourcesMonitoring.Windows;

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
