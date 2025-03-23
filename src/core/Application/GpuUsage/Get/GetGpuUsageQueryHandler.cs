using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.CpuUsage.Queries;
using Vordr.Domain.Entities;

namespace Vordr.Application.GpuUsage.Get;

public class GetGpuUsageQueryHandler(IGpuLoadRepository repository) : IRequestHandler<GetGpuUsageQuery, IEnumerable<GpuLoad>>
{

    public async Task<IEnumerable<GpuLoad>> Handle(GetGpuUsageQuery request, CancellationToken cancellationToken)
    {
        return await repository.RetrieveAsync(request);
    }
}
