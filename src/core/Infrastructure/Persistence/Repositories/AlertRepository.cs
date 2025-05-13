using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Enums;
using Alert = Vordr.Domain.Entities.Alert;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class AlertRepository(MongoDbClient client, ILogger<AlertRepository> logger) : IAlertRepository
{
    private readonly IMongoCollection<Alert> _collection = client.AlertsCollection();

    public async Task<IEnumerable<Alert>> GetAllAsync()
    {
        try
        {
            var alerts = await _collection.Find(_ => true).ToListAsync();
            return alerts;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error fetching all alerts.");
            throw;
        }
    }

    public async Task<Alert> GetByTypeAsync(AlertType alertType)
    {
        try
        {
            var filter = Builders<Alert>.Filter.Eq(a => a.Type, alertType);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error fetching alert by type {AlertType}.", alertType);
            throw;
        }
    }

    public async Task<Alert> UpdateAsync(Alert alert)
    {
        try
        {
            var filter = Builders<Alert>.Filter.Eq(a => a.Type, alert.Type);
            var result = await _collection.ReplaceOneAsync(filter, alert);

            if (result.MatchedCount != 0)
            {
                return alert;
            }
            logger.LogWarning("No alert found with ID {AlertId} to update.", alert.Id);
            return null!;

        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error updating alert with ID {AlertId}.", alert.Id);
            throw;
        }
    }
}
