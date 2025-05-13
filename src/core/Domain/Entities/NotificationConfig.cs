namespace Vordr.Domain.Entities;

public class NotificationConfig
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; }

    public string SmtpHost { get; set; } = string.Empty;
    public int SmtpPort { get; set; }
    public string SmtpUsername { get; set; } = string.Empty;
    public string SmtpPassword { get; set; } = string.Empty;

    public bool EmailEnabled { get; set; }
    public bool PushNotificationEnabled { get; set; }
    
    public string? Receiver { get; set; }

    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
}
