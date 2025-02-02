using MongoDB.Bson;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IRamUsagesRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(Domain.Entities.RamUsage data);
}
