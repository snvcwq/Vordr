namespace CleanArchitecture.Domain.Options;

public record MongoDbOptions
{
    public required string ConnectionString { get; set; }
    public required string DataBaseName { get; set; }

}
