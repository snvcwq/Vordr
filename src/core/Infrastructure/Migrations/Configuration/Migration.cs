using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Vordr.Infrastructure.Migrations.Configuration;

public record Migration
{
    [BsonId] 
    public ObjectId Id { get; init; }  
    public required Version Version { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
    public DateTime PerformedDateTimeUtc { get; set; }
}
