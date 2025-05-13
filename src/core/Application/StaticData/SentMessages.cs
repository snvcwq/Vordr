using Vordr.Domain.Enums;

namespace Vordr.Application.StaticData;

public static class SentMessages
{
    private static readonly Dictionary<AlertType, DateTime> LastSentTimes = new();

    private static readonly TimeSpan ThrottleInterval = TimeSpan.FromMinutes(5);

    public static bool CanSend(AlertType type)
    {
        if (!LastSentTimes.TryGetValue(type, out var lastSent))
        {
            // No alert of this type sent before
            return true;
        }

        return (DateTime.UtcNow - lastSent) >= ThrottleInterval;
    }

    public static void MarkSent(AlertType type)
    {
        LastSentTimes[type] = DateTime.UtcNow;
    }

    public static DateTime? GetLastSent(AlertType type)
    {
        return LastSentTimes.TryGetValue(type, out var time) ? time : null;
    }
}
