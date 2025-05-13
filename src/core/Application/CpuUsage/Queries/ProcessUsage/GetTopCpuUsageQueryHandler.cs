using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Models;

namespace Vordr.Application.CpuUsage.Queries.ProcessUsage;

public class GetTopCpuUsageQueryHandler(IProcessMetricsRepository repository, IProcessDataRepository processDataRepository) : IRequestHandler<GetTopCpuUsageQuery, IEnumerable<TopCpu>>
{

    public async Task<IEnumerable<TopCpu>> Handle(GetTopCpuUsageQuery request, CancellationToken cancellationToken)
    {
        var topUsage = await repository.GetTopUsage(request);
        var uniqueProcessMetrics = topUsage
            .GroupBy(pm => pm.ProcessObjectId)
            .Select(g => g.OrderByDescending(pm => pm.CpuUsage).First())
            .OrderByDescending(pm => pm.CpuUsage)
            .Take(5)
            .ToList();

        var result = new List<TopCpu>();
        foreach (var group in uniqueProcessMetrics)
        {
            var data = await processDataRepository.RetrieveAsync(group.ProcessObjectId, request.ClientId);
            if (data is null)
            {
                break;
            }
            result.Add(new TopCpu
            {
                Time = group.LastModifiedUtc, Name = data.Name, Load = group.CpuUsage
            });
        }
        return result;
    }
}
