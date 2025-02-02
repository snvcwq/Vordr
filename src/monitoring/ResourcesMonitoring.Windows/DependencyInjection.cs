using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.ResourcesMonitoring.Windows.Cpu;
using Vordr.ResourcesMonitoring.Windows.Process;
using Vordr.ResourcesMonitoring.Windows.Ram;

namespace Vordr.ResourcesMonitoring.Windows;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddWindowsResourceCollectors(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped< IProcessDataCollector, ProcessDataCollector>();
        builder.Services.AddScoped< IRamUsageCollector, RamUsageCollector>();
        builder.Services.AddScoped< ICpuUsageCollector, CpuUsageCollector>();
        
        return builder;
    }
}
