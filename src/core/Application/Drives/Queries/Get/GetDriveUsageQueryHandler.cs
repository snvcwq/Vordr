using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.Drives.Queries.Get;

public class GetDriveUsageQueryHandler(IDriveInfoRepository repository) : IRequestHandler<GetDriveUsageQuery, IEnumerable<DriveInformation>>
{

    public async Task<IEnumerable<DriveInformation>> Handle(GetDriveUsageQuery request, CancellationToken cancellationToken)
    {
        return await repository.RetrieveAsync(request);
    }

}
