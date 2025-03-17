using MongoDB.Bson;
using Vordr.Application.Models.Process;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.Process;

public static class ProcessStatsMappings
{
    public static ProcessMetrics ToProcessMetrics(this ProcessStats processStats, ObjectId processId) =>
        new()
        {
            LastModifiedUtc = DateTime.UtcNow,
            ProcessObjectId = processId,
            CpuUsage = processStats.CpuUsage,
            RamUsage = processStats.RamUsage,
            ThreadCount = processStats.ThreadCount,
            HandleCount = processStats.HandleCount,
        };

}
