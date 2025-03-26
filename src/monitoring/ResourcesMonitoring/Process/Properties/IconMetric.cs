using System.Diagnostics.CodeAnalysis;

namespace Vordr.ResourcesMonitoring.Windows.Process.Properties;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
public static class IconMetric
{
    public static byte[]? GetIcon(this System.Diagnostics.Process process)
    {
        try
        {
            if (process.MainModule is not null)
            {
                var path = process.MainModule?.FileName;
                if (string.IsNullOrEmpty(path) || !File.Exists(path))
                    return null;

                using var icon = System.Drawing.Icon.ExtractAssociatedIcon(path);
                using var ms = new MemoryStream();
                icon?.Save(ms);
                return ms.ToArray();   
            }
            return null;
        }
        catch
        {
            return null;
        }
    }
}
