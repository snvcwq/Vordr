using Microsoft.Extensions.Hosting;

namespace CleanArchitecture.ServiceDefaults;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddServiceDefaults(this IHostApplicationBuilder builder)
    {
        return builder;
    }
}
