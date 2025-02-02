using System.Text.Json.Serialization;

namespace Vordr.Domain.Common;

public record BaseMetric()
{
    [JsonIgnore]
    [BsonId]
    public ObjectId Id { get; init; }

    public DateTime CapturedAtUtc { get; set; } = DateTime.UtcNow; 
}
