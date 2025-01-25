using Microsoft.Extensions.Hosting;

namespace CleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddInfrastructureServices(this IHostApplicationBuilder builder)
    {

        return builder;
    }
}
