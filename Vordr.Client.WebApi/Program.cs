using Serilog;
using Vordr.Client.WebApi;
using Vordr.Client.WebApi.Interfaces;
using Vordr.Client.WebApi.Interfaces.BackgroundJobs;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();

var app = builder.Build();

var regService = app.Services.GetRequiredService<IRegistrationService>();

var registered = regService.RegisterApplication().GetAwaiter().GetResult();
if (registered)
    app.ScheduleMonitoring();
else
    Log.Debug("Failed to register application.No monitoring will be done");

app.Run();
