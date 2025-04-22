namespace Vordr.Client.Monitoring.Hardware;

public static class Convertor
{
    public static double ToGb(this double value) =>
        value / (1024.0 * 1024.0 * 1024.0);

}
