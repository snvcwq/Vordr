using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.IO;
using System.Reflection;
using System.Windows;
using Vordr.Application;
using Vordr.Domain;
using Vordr.Infrastructure;
using Vordr.Infrastructure.Extensions;

namespace Presentation;

public partial class App : Application
{
    public static IHost? AppHost { get; private set; }
    public static IConfiguration? Configuration { get; private set; }

    public App()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .AddUserSecrets<App>()
            .Build();
        
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                //Add Hangfire and MongoDB options
                services
                    .AddDomainServices()
                    .AddApplicationServices()
                    .AddInfrastructureServices(Configuration)
                    .AddSingleton<MainWindow>();
            }).Build();
        
        ConfigureLogging();
        AppHost
            .ExecuteMigrations().GetAwaiter().GetResult()
            .ScheduleMonitoring().GetAwaiter().GetResult();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();
        var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
        startupForm.Show();
        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
    
    private static void ConfigureLogging()
    {
        Log.Logger = new LoggerConfiguration()  
            .MinimumLevel.Debug()  
            .WriteTo.Console()  
            //.WriteTo.File("logs\\Log_SerilogDemoWPF.txt", rollingInterval: RollingInterval.Day)  
            .CreateLogger(); 
    }
    
}
