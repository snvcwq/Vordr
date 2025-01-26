using Microsoft.Extensions.Hosting;

namespace Vordr.Domain;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddDomainServices(this IHostApplicationBuilder builder)
    {
        return builder;
    }
}
