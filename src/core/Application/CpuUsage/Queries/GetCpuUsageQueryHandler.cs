using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.CpuUsage.Queries;

public class GetCpuUsageQueryHandler(ICpuLoadRepository repository) : IRequestHandler<GetCpuUsageQuery, IEnumerable<CpuLoad>>
{

    public async Task<IEnumerable<CpuLoad>> Handle(GetCpuUsageQuery request, CancellationToken cancellationToken)
    {
        return await repository.RetrieveAsync(request);
    }
}
