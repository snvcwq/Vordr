using Microsoft.AspNetCore.Builder;

namespace Vordr.ResourceMonitoring.MacOs;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddMacOsResourceCollectors(this WebApplicationBuilder builder)
    {
        
        return builder;
    }
}
