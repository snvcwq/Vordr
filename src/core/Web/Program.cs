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
var x = builder.Configuration;
builder
    .AddDomainServices()
    .AddApplicationServices()
    .AddInfrastructureServices()
    .AddServiceDefaults()
    .AddPresentationServices();

var app = builder.Build();

app.ConfigureScalar();

await app.ExecuteMigrations();


app.MapControllers();
app.UseHttpsRedirection();

app.Run();
