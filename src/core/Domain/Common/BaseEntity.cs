using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace Vordr.Domain.Common
{
    public record BaseEntity
    {
        [JsonIgnore]
        public BsonObjectId Id { get; } = new(ObjectId.GenerateNewId());

        public DateTime LastModifiedUtc { get; set; }

        public void UpdateLastModifiedDate() =>
            LastModifiedUtc = DateTime.UtcNow;

    }
}
