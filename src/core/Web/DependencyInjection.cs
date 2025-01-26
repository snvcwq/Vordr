using Serilog;
using Vordr.Web.Options;

namespace Vordr.Web;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddPresentationServices(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog();
        
        builder.Services.Configure<DashboardOptions>(builder.Configuration.GetSection(nameof(DashboardOptions)));
        
        ConfigureLogging();
        return builder;
    }

    private static void ConfigureLogging()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            //.WriteTo.File("logs", rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }
}
