using Vordr.Infrastructure.Options;
using Vordr.Web.Options;

namespace Vordr.Web;

public static class DependencyInjection
{
    public static IHostApplicationBuilder AddPresentationServices(this IHostApplicationBuilder builder)
    {
        builder.Services.Configure<MongoDbOptions>(builder.Configuration.GetSection(nameof(DashboardOptions)));

        return builder;
    }
}
