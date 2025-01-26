using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Persistence;
using Version = Vordr.Infrastructure.Migrations.Configuration.Version;

namespace Vordr.Infrastructure.Migrations;

public class SeedDefaultConfigurationMigration(MongoDbClient client) : IMigration
{
    private MongoDbClient _client = client;
    
    public Version Version { get; set; } = new(1, 0, 0);

    public string Name { get; set; } = nameof(SeedDefaultConfigurationMigration);
    
    public string Description { get; set; } = "Seed monitoring configuration collection with default configuration settings where all monitoring is disabled";
    
    public Task<bool> ExecuteAsync()
    {
        
        return Task.FromResult(true);
    }
}
