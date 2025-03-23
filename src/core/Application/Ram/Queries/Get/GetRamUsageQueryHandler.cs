using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.Ram.Queries.Get;

public class GetRamUsageQueryHandler(IRamUsagesRepository repository) : IRequestHandler<GetRamUsageQuery, IEnumerable<RamUsage>>
{

    public async Task<IEnumerable<RamUsage>> Handle(GetRamUsageQuery request, CancellationToken cancellationToken)
    {
        return await repository.RetrieveAsync(request);
    }
}
