using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;
using Vordr.Infrastructure.Constants;
using Vordr.Infrastructure.Persistence;

namespace Vordr.Infrastructure.Migrations.Configuration;

public class AddAlertsMigration(
    MongoDbClient client,
    ILogger<AddAlertsMigration> logger)
    : IMigration
{
    
    private readonly IMongoCollection<Alert> _alertCollection = client.Database().GetCollection<Alert>(MongoCollections.Alerts);
    public Version Version { get; set; } = new(1, 2, 0);
    public string Name { get; set; } = nameof(AddAlertsMigration);
    public string Description { get; set; } = "Add initial alerts list";

    public async Task<bool> ExecuteAsync()
    {
        try
        { 
            var initialAlerts = new List<Alert>
            {
                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.ComputerDisconnected,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.GpuIsMoreThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.GpuTempIsMoreThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.CpuIsMoreThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.CpuTempIsMoreThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.RamIsMoreThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.DriveIsMoreThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.BatteryLevelIsLessThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.BatteryDegradationLevelIsLessThan,
                    Value = "",
                    Enabled = false,
                },                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.ProcessUsesCpuMoreThan,
                    Value = "",
                    Enabled = false,
                }
                ,                new()
                {
                    Id = ObjectId.GenerateNewId(),
                    Type =AlertType.ProcessUsesRamMoreThan,
                    Value = "",
                    Enabled = false,
                },
             
            };

            await _alertCollection.InsertManyAsync(initialAlerts);

        }
        catch (Exception e)
        {
            logger.LogError("An error occured when executing {@MigrationName}. Message: {@ErrorMessage}", Name, e.Message);
            return false;
        }
        return true;
    }
}
