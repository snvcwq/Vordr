using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.ResourcesMonitoring.Windows.Process;

namespace Vordr.ResourcesMonitoring.Windows;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddWindowsResourceCollectors(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped< IProcessDataCollector, ProcessDataCollector>();
        return builder;
    }
}
