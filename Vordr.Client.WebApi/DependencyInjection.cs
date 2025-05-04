using Hangfire;
using Hangfire.MemoryStorage;
using LibreHardwareMonitor.Hardware;
using Serilog;
using Vordr.Client.Monitoring;
using Vordr.Client.WebApi.BackgroundJobs;
using Vordr.Client.WebApi.Interfaces;
using Vordr.Client.WebApi.Interfaces.BackgroundJobs;
using Vordr.Client.WebApi.Options;
using Vordr.Client.WebApi.Service;
using Vordr.Common.Config;

namespace Vordr.Client.WebApi;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog();
        builder.Services.AddWindowsResourceCollectors();
        builder.Services.AddHangfire(config =>
        {
            config.UseMemoryStorage();
        });

        builder.Services.AddHangfireServer();
        builder.Services.AddScoped<ISocketClientService, SocketClientService>();
        builder.Services.AddScoped<IRegistrationService, RegistrationService>();
        builder.Services.AddScoped<IRegistrationService, RegistrationService>();
        builder.Services.AddScoped<IMonitoringService, MonitoringService>();
        builder.Services.AddScoped<IMonitoringScheduler, MonitoringScheduler>();

        builder.Services.Configure<RegistrationOptions>(builder.Configuration.GetSection(nameof(RegistrationOptions)));
        builder.Services.Configure<MonitoringOptions>(builder.Configuration.GetSection(nameof(MonitoringOptions)));
        builder.Services.Configure<MonitoringConfiguration>(builder.Configuration.GetSection(nameof(MonitoringConfiguration)));
        
        ConfigureLogging();
        return builder;
    }
    
    public static WebApplication ScheduleMonitoring(this WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var scheduler = scope.ServiceProvider.GetRequiredService<IMonitoringScheduler>();
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
