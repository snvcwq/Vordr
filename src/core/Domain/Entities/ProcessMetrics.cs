using System.ComponentModel.DataAnnotations;
using Vordr.Domain.Common;

namespace Vordr.Domain.Entities
{
    public record ProcessMetrics : BaseEntity
    {
        public required ObjectId ProcessObjectId { get; set; }

        public required double CpuUsage { get; set; }
        
        public required double RamUsage { get; set; }
        
        public int ThreadCount { get; set; }
        
        public int HandleCount { get; set; }
        

    }
}
