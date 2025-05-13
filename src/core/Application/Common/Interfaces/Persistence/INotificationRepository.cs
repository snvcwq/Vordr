using MongoDB.Bson;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface INotificationRepository
{
    Task<ErrorOr<ObjectId>> UpsertAsync(NotificationConfig settings);
    Task<NotificationConfig?> GetAsync();
}
