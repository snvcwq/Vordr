namespace Vordr.Infrastructure.Options;

public record HangfireOptions
{
    public required string DatabaseName { get; set; }
}
