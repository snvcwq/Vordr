using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class NotificationRepository(MongoDbClient client, ILogger<NotificationRepository> logger)
    : INotificationRepository
{
    private readonly IMongoCollection<NotificationConfig> _collection = client.NotificationConfigCollection();

    public async Task<ErrorOr<ObjectId>> UpsertAsync(NotificationConfig settings)
    {
        try
        {
            await _collection.DeleteManyAsync(FilterDefinition<NotificationConfig>.Empty);

            settings.Id = ObjectId.GenerateNewId();

            await _collection.InsertOneAsync(settings);

            return settings.Id;
        }
        catch (Exception ex)
        {
            logger.LogError("Failed to insert notification config: {Message} - {StackTrace}", ex.Message, ex.StackTrace);
            return Error.Failure("Failed to save settings.");
        }
    }

    public async Task<NotificationConfig?> GetAsync()
    {
        try
        {
            return await (await _collection.FindAsync(FilterDefinition<NotificationConfig>.Empty)).FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {
            logger.LogError("Failed to retrieve notification settings: {Message} - {StackTrace}", ex.Message, ex.StackTrace);
            return null;
        }
    }
}
