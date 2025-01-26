using Microsoft.AspNetCore.Builder;

namespace Vordr.ResourceMonitoring.Linux;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddLinuxResourceCollectors(this WebApplicationBuilder builder)
    {

        
        return builder;
    }
}
