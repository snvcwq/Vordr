using MongoDB.Bson;
using Vordr.Application.CpuUsage.Queries;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface ICpuLoadRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(Domain.Entities.CpuLoad data);
    public Task<IEnumerable<CpuLoad>> RetrieveAsync(GetCpuUsageQuery query);

}
