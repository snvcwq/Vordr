using Microsoft.AspNetCore.Builder;

namespace Vordr.ServiceDefaults;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddServiceDefaults(this WebApplicationBuilder builder)
    {
        return builder;
    }
}
