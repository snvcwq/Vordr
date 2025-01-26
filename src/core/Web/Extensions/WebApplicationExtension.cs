using Vordr.Web.Options;
using Microsoft.Extensions.Options;
using Scalar.AspNetCore;

namespace Vordr.Web.Extensions;

public static class WebApplicationExtension
{
    internal static WebApplication ConfigureScalar(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dashboardOptions = scope.ServiceProvider.GetRequiredService<IOptions<DashboardOptions>>().Value;

        if (!dashboardOptions.UseScalar)
            return app;

        app.MapOpenApi();
        app.MapScalarApiReference(options =>
            options.Theme = ScalarTheme.DeepSpace);

        return app;
    }
}
