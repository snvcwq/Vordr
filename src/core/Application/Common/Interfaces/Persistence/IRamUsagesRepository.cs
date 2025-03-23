using MongoDB.Bson;
using Vordr.Application.Ram.Queries.Get;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IRamUsagesRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(Domain.Entities.RamUsage data);
    public Task<IEnumerable<RamUsage>> RetrieveAsync(GetRamUsageQuery query);
}
