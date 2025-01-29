using Vordr.Domain.Common;

namespace Vordr.Domain.Entities
{
    public record ProcessMetrics : BaseEntity
    {
        public const string CollectionName = "processMetrics";
        
        public required int Pid { get; set; }

        public required double CpuUsage { get; set; }
        
        public required long RamUsage { get; set; }
        
        public required long MaxWorkingSet { get; set; }

        public double GpuUsage { get; set; }
        
        public int ThreadCount { get; set; }
        
        public int HandleCount { get; set; }

        public long DiskReadBytes { get; set; }
        public long DiskWriteBytes { get; set; }

        public long NetworkSentBytes { get; set; }
        public long NetworkReceivedBytes { get; set; }
    }
}
