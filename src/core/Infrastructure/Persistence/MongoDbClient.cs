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

    public IMongoDatabase Database() =>
        Client.GetDatabase(Db);
}
