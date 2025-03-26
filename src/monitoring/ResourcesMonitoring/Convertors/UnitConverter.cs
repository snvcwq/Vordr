namespace Vordr.ResourcesMonitoring.Windows.Convertors;

internal static class UnitConverter
{
    internal static double KilobytesToMegabytes(long kilobytes)
    {
        return kilobytes / 1024.0; // 1 MB = 1024 KB
    }
    
    public static double BytesToMb(long bytes)
    {
        return bytes / (1024.0 * 1024.0);
    }
}
