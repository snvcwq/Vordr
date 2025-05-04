using Microsoft.Extensions.Hosting.WindowsServices;
using Serilog;
using Vordr.Client.WebApi;
using Vordr.Client.WebApi.Interfaces;


var builder = WebApplication.CreateBuilder(args);
if (WindowsServiceHelpers.IsWindowsService())
{
    builder.WebHost.UseContentRoot(AppContext.BaseDirectory);
}

builder.Host.UseWindowsService();
builder.AddServices();

var app = builder.Build();

var scope = app.Services.CreateScope();
var regService = scope.ServiceProvider.GetRequiredService<IRegistrationService>();
var registered = regService.RegisterApplication().GetAwaiter().GetResult();
if (registered)
    app.ScheduleMonitoring();
else
    Log.Debug("Failed to register application.No monitoring will be done");

app.Run();
