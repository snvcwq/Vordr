using MongoDB.Bson;
using Vordr.Domain.Entities;

namespace Vordr.Application.Notfication.UpdateConfig;

public record UpdateConfigCommand(NotificationConfig Config) : IRequest<ErrorOr<ObjectId>>
{
    
}
