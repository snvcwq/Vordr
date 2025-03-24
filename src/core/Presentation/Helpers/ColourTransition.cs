using SkiaSharp;

namespace Presentation.Helpers;

public static class ColorTransition
{
    private static readonly Color GreenColor = Color.FromArgb(43, 152, 121);
    private static readonly Color RedColor = Color.FromArgb(169, 86, 81);

    public static Color GetColorGreenToRed(int value)
    {
        value = Math.Max(0, Math.Min(100, value));

        var t = value / 100f;

        var r = (int)(GreenColor.R + t * (RedColor.R - GreenColor.R));
        var g = (int)(GreenColor.G + t * (RedColor.G - GreenColor.G));
        var b = (int)(GreenColor.B + t * (RedColor.B - GreenColor.B));

        return Color.FromArgb(r, g, b);
    }

    public static Color GetColorRedToGreen(int value)
    {
        value = Math.Max(0, Math.Min(100, value));

        var t = value / 100f;
        var r = (int)(RedColor.R + t * (GreenColor.R - RedColor.R));
        var g = (int)(RedColor.G + t * (GreenColor.G - RedColor.G));
        var b = (int)(RedColor.B + t * (GreenColor.B - RedColor.B));

        return Color.FromArgb(r, g, b);
    }
    public static SKColor ToSKColor(this Color color)
    {
        return new SKColor(color.R, color.G, color.B, color.A);
    }
}
