namespace Presentation.Helpers;


    public class DateTimeConverter
    {
        // Convert DateTime to Ticks (for your use case)
        public long Convert(DateTime value)
        {
            return value.Ticks;
        }

        // Convert Ticks back to DateTime (if needed, though in your case you may not need it)
        public DateTime ConvertBack(long value)
        {
            return new DateTime(value);
        }
    }
