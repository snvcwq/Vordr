using CleanArchitecture.Application;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Options;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.ServiceDefaults;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoDbOptions>(builder.Configuration.GetSection(nameof(MongoDbOptions)));
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.Configure<MongoDbOptions>(builder.Configuration.GetSection(nameof(MongoDbOptions)));

builder
    .AddDomainServices()
    .AddApplicationServices()
    .AddInfrastructureServices()
    .AddServiceDefaults();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options => 
        options.Theme = ScalarTheme.DeepSpace);
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();
