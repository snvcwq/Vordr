using System.Text.Json.Serialization;

namespace Vordr.Domain.Common
{
    public record BaseEntity
    {
        [JsonIgnore]
        [BsonId]
        public ObjectId Id { get; init; }

        public DateTime LastModifiedUtc { get; set; } = DateTime.UtcNow; 

    }
}
