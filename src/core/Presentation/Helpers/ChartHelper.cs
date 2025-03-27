using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Drawing;
using LiveChartsCore.Kernel.Events;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Collections.ObjectModel;

namespace Presentation.Helpers;

public static class ChartHelper
{
    public static string? ValidateTime(int hour, int minute)
    {
        if (hour is < 0 or > 23)
            return "Invalid Time. hour must be between 0 and 23";
        return minute is < 0 or >= 60 ? "Invalid Time. minute must be between 0 and 59" : null;
    }

    public static string? ValidateStartAndEndTime(DateTime startTime, DateTime endTime)
    {
        return startTime > endTime ? "Invalid Time.startTime must be greater than endTime." : null;
    }

    public static DateTime DefineTime(DateTime time, int hour, int minute)
    {
        return new DateTime(time.Year, time.Month, time.Day, hour, minute, 0, DateTimeKind.Local).ToUniversalTime();
    }

    public static IEnumerable<ICartesianAxis> DefineChartX(string name, DateTime startDate, DateTime endDate)
    {
        var timeDifference = (startDate - endDate).TotalHours;

        return [new DateTimeAxis(TimeSpan.FromDays(1), date => date.ToString("d MMM HH:mm"))];
    }
    
    public static IEnumerable<ICartesianAxis> DefineChartY(string name)
    {
        return new Axis[]
        {
            new()
            {
                Name = name,
                Position = AxisPosition.Start,
                ShowSeparatorLines = true,
                IsInverted = false,
                TicksAtCenter = false,
            }
        };
    }

    public static IEnumerable<ISeries> DefineChart(IList<DateTimePoint> data)
    {
        var chartValues = new ObservableCollection<DateTimePoint>(data);

        var series = new LineSeries<DateTimePoint>
        {
            Values = chartValues,
            LineSmoothness = 1,
            Fill = new SolidColorPaint(Color.FromArgb(226,228,233).ToSKColor()),
            DataLabelsPaint = new SolidColorPaint(new SKColor(226,228,233)),
            DataLabelsPosition = DataLabelsPosition.Top,
            DataLabelsFormatter = _ => string.Empty,
            DataPadding = new LvcPoint(),
            Stroke = new SolidColorPaint(Color.FromArgb(20, 39, 78).ToSKColor()),

        }.OnPointMeasured(point =>
        {
            if (point.Visual is null) return;

            var paint = new SolidColorPaint(Color.FromArgb(20, 39, 78).ToSKColor());
            point.Visual.Fill = paint;
            point.Visual.Width = 0;
        });

        return [series];
    }
}
