using MongoDB.Bson;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface ICpuLoadRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(Domain.Entities.CpuLoad data);

}
