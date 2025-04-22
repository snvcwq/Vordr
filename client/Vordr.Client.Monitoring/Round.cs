namespace Vordr.Client.Monitoring;

public static class Round
{
    public static double RoundUp(this float value, int digits = 2) =>
    Math.Round(value, digits, MidpointRounding.AwayFromZero);
    
    public static double RoundUp(this double value, int digits = 2) =>
        Math.Round(value, digits, MidpointRounding.AwayFromZero);
}
