using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class DriveInfoRepository(MongoDbClient client, ILogger<DriveInfoRepository> logger) : IDriveInfoRepository
{
    private readonly IMongoCollection<DriveInformation> _collection = client.DriveInfoCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(DriveInformation data)
    {
        try
        {
            await _collection.InsertOneAsync(data);
            return data.Id;

        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading drive information load to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
}
