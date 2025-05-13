using MongoDB.Driver;
using Vordr.Domain.Entities;
using Vordr.Infrastructure.Constants;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Options;

namespace Vordr.Infrastructure.Persistence;

public class MongoDbClient(IOptions<MongoDbOptions> mongoOptions)
{
    private MongoClient Client { get; } = new(mongoOptions.Value.ConnectionString);

    private string Db { get; } = mongoOptions.Value.DataBaseName;

    public IMongoCollection<ProcessData> ProcessDataCollection() =>
        Database().GetCollection<ProcessData>(MongoCollections.ProcessData);

    public IMongoCollection<ProcessMetrics> ProcessMetricsCollection() =>
        Database().GetCollection<ProcessMetrics>(MongoCollections.ProcessMetrics);

    public IMongoCollection<Migration> MigrationsCollection() =>
        Database().GetCollection<Migration>(MongoCollections.Migrations);
    public IMongoCollection<MonitoringConfiguration> MonitoringConfigurationCollection() =>
        Database().GetCollection<MonitoringConfiguration>(MongoCollections.MonitoringConfiguration);

    public IMongoCollection<RamUsage> RamUsagesCollection() =>
        Database().GetCollection<RamUsage>(MongoCollections.RamUsage);
    public IMongoCollection<HardwareComponents> HardwareComponentsCollection() =>
        Database().GetCollection<HardwareComponents>(MongoCollections.HardwareComponents);
    
    public IMongoCollection<CpuLoad> CpuLoadsCollection() =>
        Database().GetCollection<CpuLoad>(MongoCollections.CpuLoad);
    
    public IMongoCollection<PowerSupply> PowerSupplyCollection() =>
        Database().GetCollection<PowerSupply>(MongoCollections.PowerSupplyInfo);
    
    public IMongoCollection<GpuLoad> GpuLoadsCollection() =>
        Database().GetCollection<GpuLoad>(MongoCollections.GpuLoad);
    
    public IMongoCollection<DriveInformation> DriveInfoCollection() =>
        Database().GetCollection<DriveInformation>(MongoCollections.DriveInfo);
    
    public IMongoCollection<NetworkInformation> NetworkInfoCollection() =>
        Database().GetCollection<NetworkInformation>(MongoCollections.NetworkInfo);
    
    public IMongoCollection<Workstation> WorkstationsCollection() =>
        Database().GetCollection<Workstation>(MongoCollections.Workstation);
    public IMongoCollection<NotificationConfig> NotificationConfigCollection() =>
        Database().GetCollection<NotificationConfig>(MongoCollections.NotificationConfig);
    
    public IMongoCollection<Vordr.Domain.Entities.Alert> AlertsCollection() =>
        Database().GetCollection<Vordr.Domain.Entities.Alert>(MongoCollections.Alerts);
    public IMongoDatabase Database() =>
        Client.GetDatabase(Db);
}
