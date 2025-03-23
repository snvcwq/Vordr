using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation.Slices;
using Serilog;
using Vordr.Application;
using Vordr.Application.HardwareComponent.Queries;
using Vordr.Application.HardwareComponent.Queries.RetrieveAsync;
using Vordr.Domain;
using Vordr.Infrastructure;
using Vordr.Infrastructure.Extensions;

namespace Presentation;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Application.SetCompatibleTextRenderingDefault(false);
        ConfigureLogging();
        var host = CreateHostBuilder().Build()
            .ExecuteMigrations().GetAwaiter().GetResult()
            .ScheduleMonitoring().GetAwaiter().GetResult();

        var sender = host.Services.GetRequiredService<ISender>();
        var t  = sender.Send(new RetrieveHardwareComponentQueryAsync()).GetAwaiter().GetResult();

        Task.Run(() =>
        {
            host.Run();
        });
        Application.Run(new MainForm(host.Services, sender));

    }
    private static IHostBuilder CreateHostBuilder()
    {
        return 
        Host.CreateDefaultBuilder().ConfigureAppConfiguration(
                (context,config)=>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddEnvironmentVariables()
                        .AddUserSecrets<Class>();

                })
            .ConfigureServices((context, services) =>
            {
                services
                    .AddDomainServices()
                    .AddApplicationServices()
                    .AddInfrastructureServices(context.Configuration)
                    .AddPresentation();
            });
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
