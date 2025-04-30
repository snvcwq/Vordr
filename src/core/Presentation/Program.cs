using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Presentation.Options;
using Presentation.Slices;
using Presentation.Socket;
using Serilog;
using System.Net;
using Vordr.Application;
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
            .ExecuteMigrations().GetAwaiter().GetResult();
        
        host.StartSocketServer();

        var form = host.Services.GetRequiredService<MainForm>();

        Task.Run(() =>
        {
            host.Run();
        });
        Application.Run(form);

    }

    private static void StartSocketServer(this IHost host)
    {
        Task.Run(async () =>
        {
            var socketSettings = host.Services.GetRequiredService<SocketSettings>();
            var socketOptions = host.Services.GetRequiredService<IOptions<SocketOptions>>().Value;
            var sender = host.Services.GetRequiredService<ISender>();
            var address = socketOptions.LocalDeployment ? Dns.GetHostName() : socketOptions.DnsAddress;
            var (socket, endpoint) = await socketSettings.CreateSocket(socketOptions.Port, address);
            socket.StartListening(endpoint);
            await socket.StartAcceptingClientsAsync(sender);
        });
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
