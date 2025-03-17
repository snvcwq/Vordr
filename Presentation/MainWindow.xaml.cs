using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Windows;
using System.Windows.Input;


namespace Presentation;

public partial class MainWindow : Window
{
    public List<ISeries> SeriesCollection { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        // Create sample data for the chart
        SeriesCollection = new List<ISeries>
        {
            new ColumnSeries<double>
            {
                Name = "Marketing Costs",
                Values = new List<double> { 100, 200, 300, 400, 500 }
            },
            new ColumnSeries<double>
            {
                Name = "Sales Costs",
                Values = new List<double> { 150, 250, 350, 450, 550 }
            }
        };

        Task.Run(() => UpdateChartData());

        // Bind the data to the chart
        DataContext = this;
    }
    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            DragMove();
        }
    }
    
    private void UpdateChartData()
    {
        // Simulate waiting for 10 seconds
        Thread.Sleep(10000);

        // Generate new data after 10 seconds
        var newData1 = new List<double> { 0, 0, 0, 420, 520 };
        var newData2 = new List<double> { 0, 0, 0, 470, 570 };

        // Update the data safely on the UI thread
        Dispatcher.Invoke(() =>
        {
            // Update the values in the SeriesCollection
            ((ColumnSeries<double>)SeriesCollection[0]).Values = newData1;
            ((ColumnSeries<double>)SeriesCollection[1]).Values = newData2;

            // Notify the chart that the data has been updated
            // (optional, but can help with performance when there are lots of updates)
            // If you're using LiveCharts v2 or later, it might automatically update after changing the Values.
            // If you're using LiveCharts v1, you might need to use a method like .InvalidateSeries() to force an update.
        });
    }
}
