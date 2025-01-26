using Microsoft.AspNetCore.Builder;

namespace Vordr.Domain;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddDomainServices(this WebApplicationBuilder builder)
    {
        return builder;
    }
}
