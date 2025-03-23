namespace Presentation.Helpers;

public static class ChartHelper
{
    public static string? ValidateTime(int hour, int minute)
    {
        if(hour is < 0 or > 23)
            return "Invalid Time. hour must be between 0 and 23";
        return minute is < 0 or >= 60 ? "Invalid Time. minute must be between 0 and 59" : null;
    }
    
    public static string? ValidateStartAndEndTime(DateTime startTime, DateTime endTime)
    {
        return startTime > endTime ? "Invalid Time.startTime must be greater than endTime." : null;
    }
    
    public static DateTime DefineTime(DateTime time, int hour, int minute)
    {
        return new DateTime(time.Year, time.Month, time.Day, hour, minute, 0, DateTimeKind.Utc);
    }
    public static List<string> CalculateLegendDate(DateTime startDate, DateTime endDate, int dataPointsCount)
    {
        var labels = new List<string>();

        var isShortRange = (endDate - startDate).TotalDays < 1;
        var isHourRange = (endDate - startDate).TotalHours < 1;
        const int intervalCount = 5;

        var intervalStep = 
            
            isShortRange 
            ? ( isHourRange 
                ? TimeSpan.FromMinutes((endDate - startDate).TotalMinutes / (intervalCount - 1)) 
                : TimeSpan.FromHours((endDate - startDate).TotalHours / (intervalCount - 1)))
            : TimeSpan.FromDays((endDate - startDate).TotalDays / (intervalCount - 1)); 

        for (var i = 0; i < intervalCount; i++)
        {
            var labelDate = startDate.AddTicks(intervalStep.Ticks * i);

            var label = labelDate.ToString(isShortRange ? "HH:mm" : "MM/dd");
            labels.Add(label);
        }

        return labels;
    }
}
