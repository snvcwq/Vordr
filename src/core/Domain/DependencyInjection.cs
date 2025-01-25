using CleanArchitecture.Domain.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CleanArchitecture.Domain;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddDomainServices(this IHostApplicationBuilder builder)
    {
        builder.Services.Configure<MongoDbOptions>(builder.Configuration.GetSection(nameof(MongoDbOptions)));

        return builder;
    }
}
