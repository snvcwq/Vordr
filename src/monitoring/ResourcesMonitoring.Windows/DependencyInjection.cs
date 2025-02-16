using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.ResourcesMonitoring.Windows.Cpu;
using Vordr.ResourcesMonitoring.Windows.Process;
using Vordr.ResourcesMonitoring.Windows.Ram;

namespace Vordr.ResourcesMonitoring.Windows;

public static class DependencyInjection
{
    public static IServiceCollection AddWindowsResourceCollectors(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped< IProcessDataCollector, ProcessDataCollector>();
        serviceCollection.AddScoped< IRamUsageCollector, RamUsageCollector>();
        serviceCollection.AddScoped< ICpuUsageCollector, CpuUsageCollector>();
        
        return serviceCollection;
    }
}
