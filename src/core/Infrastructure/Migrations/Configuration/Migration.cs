using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Vordr.Infrastructure.Migrations.Configuration;

public record Migration
{
    private const string CollectionName = "migrations";

    [BsonId] 
    public ObjectId Id { get; init; }  
    
    public required Version Version { get; init; }
    
    public required string Name { get; init; }

    public DateTime PerformedDateTimeUtc { get; set; }
    public static string GetCollectionName() => CollectionName;
}
