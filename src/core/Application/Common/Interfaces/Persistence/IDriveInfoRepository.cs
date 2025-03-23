using MongoDB.Bson;
using Vordr.Application.Drives.Queries.Get;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IDriveInfoRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(DriveInformation data);
    public Task<IEnumerable<DriveInformation>> RetrieveAsync(GetDriveUsageQuery query);

}
