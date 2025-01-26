using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Persistence;
using Version = Vordr.Infrastructure.Migrations.Configuration.Version;

namespace Vordr.Infrastructure.Migrations;

public class SeedDefaultConfigurationMigration(
    MongoDbClient client,
    ILogger<SeedDefaultConfigurationMigration> logger)
    : IMigration
{
    
    private readonly IMongoCollection<MonitoringConfiguration> _monitoringCollection = client.Database().GetCollection<MonitoringConfiguration>(MonitoringConfiguration.CollectionName);
    public Version Version { get; set; } = new(1, 0, 0);
    public string Name { get; set; } = nameof(SeedDefaultConfigurationMigration);
    public string Description { get; set; } ="Seed monitoring configuration collection with default configuration settings where all monitoring is disabled";

    public async Task<bool> ExecuteAsync()
    {

        try
        { 
            var monitoringConfigurations = await (await _monitoringCollection.FindAsync(FilterDefinition<MonitoringConfiguration>.Empty)).ToListAsync();

            if (monitoringConfigurations.Count > 0)
                DeleteConfigurations(monitoringConfigurations);
            
            await _monitoringCollection.InsertOneAsync( new MonitoringConfiguration
            {
                ProcessMonitoringConfig = new ProcessMonitoringConfig
                {
                    MonitoringStatus = MonitoringStatus.Disabled,
                    ScanSchedule = "",
                    MaxProcessesToScan = 100
                },
                MonitorCpu = MonitoringStatus.Disabled,
                MonitorDrives = MonitoringStatus.Disabled,
                MonitorGpu = MonitoringStatus.Disabled,
                MonitorRam = MonitoringStatus.Disabled,
                MonitorStorageDevices = MonitoringStatus.Disabled,
                MonitorMotherBoard = MonitoringStatus.Disabled,
                MonitorNetwork = MonitoringStatus.Disabled,
                MonitorPeripherals = MonitoringStatus.Disabled,
                MonitorTemperature = MonitoringStatus.Disabled,
                MonitorPowerSupply = MonitoringStatus.Disabled
            });
        }
        catch (Exception e)
        {
            logger.LogError("An error occured when executing {@MigrationName}. Message: {@ErrorMessage}", Name, e.Message);
            return false;
        }
        return true;
    }

    private void DeleteConfigurations(IEnumerable<MonitoringConfiguration> configurations)
    {
        var deletedIds = configurations.Select(c => c.Id).ToList();
            logger.LogWarning("Configuration with Ids {@Ids} are deleted during {@MigrationName}", string.Join(", ", deletedIds) , Name);
            _monitoringCollection.DeleteManyAsync(ItemWithListOfId(deletedIds));
    }

    private static FilterDefinition<MonitoringConfiguration> ItemWithListOfId(IEnumerable<ObjectId> id) =>
        Builders<MonitoringConfiguration>.Filter.In(c => c.Id, id);            
}
