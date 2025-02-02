using Serilog;
using System.Reflection;
using Vordr.Application;
using Vordr.Domain;
using Vordr.Infrastructure;
using Vordr.Infrastructure.Extensions;
using Vordr.ServiceDefaults;
using Vordr.Web;
using Vordr.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly());

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder
    .AddDomainServices()
    .AddApplicationServices()
    .AddInfrastructureServices()
    .AddServiceDefaults()
    .AddPresentationServices();

var app = builder.Build();

app.ConfigureScalar();
app.ConfigureHangfireDashboard();

await app.ExecuteMigrations();
await app.ScheduleMonitoring();


app.MapControllers();
app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.Run();
