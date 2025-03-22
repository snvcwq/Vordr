using MongoDB.Driver;
using Vordr.Domain.Entities;
using Vordr.Infrastructure.Constants;
using Vordr.Infrastructure.Persistence;

namespace Vordr.Infrastructure.Migrations.Configuration;

public class AddIndexesToBatteryMigration(
    MongoDbClient client,
    ILogger<SeedDefaultConfigurationMigration> logger)
    : IMigration
{
    
    private readonly IMongoCollection<PowerSupply> _batteryColection = client.Database().GetCollection<PowerSupply>(MongoCollections.PowerSupplyInfo);
    public Version Version { get; set; } = new(1, 1, 0);
    public string Name { get; set; } = nameof(SeedDefaultConfigurationMigration);
    public string Description { get; set; } = "Add index";

    public async Task<bool> ExecuteAsync()
    {
        try
        { 
            await _batteryColection.Indexes.CreateOneAsync(new CreateIndexModel<PowerSupply>(
                Builders<PowerSupply>.IndexKeys.Ascending(x => x.CapturedAtUtc)
            ));

        }
        catch (Exception e)
        {
            logger.LogError("An error occured when executing {@MigrationName}. Message: {@ErrorMessage}", Name, e.Message);
            return false;
        }
        return true;
    }
}
