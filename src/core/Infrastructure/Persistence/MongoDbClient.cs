using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Vordr.Infrastructure.Options;

namespace Vordr.Infrastructure.Persistence;

public class MongoDbClient(IOptions<MongoDbOptions> mongoOptions)
{
    private MongoClient Client { get; } = new(mongoOptions.Value.ConnectionString);

    private string Db { get; } = mongoOptions.Value.DataBaseName;

    public MongoClient Get() =>
        Client;

    public IMongoDatabase Database() =>
        Client.GetDatabase(Db);
}
