namespace Vordr.Infrastructure.Options;

public record MongoDbOptions
{
    public required string ConnectionString { get; init; }
    public required string DataBaseName { get; init; }

}
