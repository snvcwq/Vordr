using Vordr.Domain.Common;

namespace Vordr.Domain.Entities
{
    public record ProcessMetrics : BaseEntity
    {
        public required int Pid { get; set; }

        public required double CpuUsage { get; set; }
        
        public required long RamUsage { get; set; }
        
        public required double MaxWorkingSet { get; set; }

        public double GpuUsage { get; set; }
        
        public int ThreadCount { get; set; }
        
        public int HandleCount { get; set; }

        public double DiskReadMb { get; set; }
        
        public double DiskWriteMb { get; set; }

        public long NetworkSentBytes { get; set; }
        public long NetworkReceivedBytes { get; set; }
    }
}
