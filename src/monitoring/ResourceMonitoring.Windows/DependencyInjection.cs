using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.ResourceMonitoring.MacOs.Process;

namespace Vordr.ResourceMonitoring.MacOs;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddWindowsResourceCollectors(this WebApplicationBuilder builder)
    {

        builder.Services.AddSingleton<IProcessDataCollector, WindowsProcessDataCollector>();
        
        return builder;
    }
}
