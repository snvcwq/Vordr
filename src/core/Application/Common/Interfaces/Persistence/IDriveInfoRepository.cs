using MongoDB.Bson;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IDriveInfoRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(DriveInformation data);

}
