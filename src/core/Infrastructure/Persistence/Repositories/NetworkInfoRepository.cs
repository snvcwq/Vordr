using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class NetworkInfoRepository(MongoDbClient client, ILogger<NetworkInfoRepository> logger) : INetworkRepository
{
    private readonly IMongoCollection<NetworkInformation> _collection = client.NetworkInfoCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(NetworkInformation data)
    {
        try
        {
            await _collection.InsertOneAsync(data);
            return data.Id;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading network information load to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
}
