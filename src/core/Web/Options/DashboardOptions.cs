namespace Vordr.Web.Options;

public record DashboardOptions
{
    public bool UseScalar { get; init; }
    public bool UseHangfireDashboard { get; init; }
}
