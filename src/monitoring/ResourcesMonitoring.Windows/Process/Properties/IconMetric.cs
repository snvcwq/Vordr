using System.Diagnostics.CodeAnalysis;

namespace Vordr.ResourcesMonitoring.Windows.Process.Properties;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
internal static class IconMetric
{
    internal static byte[]? GetIcon(this System.Diagnostics.Process process)
    {
        try
        {
            var path = process.MainModule?.FileName;
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
                return null;

            using var icon = System.Drawing.Icon.ExtractAssociatedIcon(path);
            using var ms = new MemoryStream();
            icon?.Save(ms);
            return ms.ToArray();
        }
        catch
        {
            return null;
        }
    }
}
