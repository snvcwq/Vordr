using Hangfire;
using Hangfire.MemoryStorage;
using Serilog;
using Vordr.Client.WebApi.BackgroundJobs;
using Vordr.Client.WebApi.Interfaces;
using Vordr.Client.WebApi.Interfaces.BackgroundJobs;
using Vordr.Client.WebApi.Options;
using Vordr.Client.WebApi.Service;

namespace Vordr.Client.WebApi;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog();
        builder.Services.AddHangfire(config =>
        {
            config.UseMemoryStorage();
        });

        builder.Services.AddHangfireServer();
        builder.Services.AddSingleton<ISocketClientService, SocketClientService>();
        builder.Services.AddSingleton<IRegistrationService, RegistrationService>();
        builder.Services.AddSingleton<IMonitoringService, MonitoringService>();
        builder.Services.AddSingleton<IMonitoringScheduler, MonitoringScheduler>();

        builder.Services.Configure<RegistrationOptions>(builder.Configuration.GetSection(nameof(RegistrationOptions)));
        
        ConfigureLogging();
        return builder;
    }
    
    public static WebApplication ScheduleMonitoring(this WebApplication app)
    {
        var scheduler = app.Services.GetRequiredService<IMonitoringScheduler>();
        scheduler.ScheduleProcessesMonitoring();
        scheduler.ScheduleHardwareComponentMonitoring();
        scheduler.ScheduleHardwareDataMonitoring();
        
        return app;
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
