
namespace Vordr.ResourcesMonitoring.Windows.Process;

/*
internal static class GpuUsage
{
    private static readonly List<IHardware> Gpus = [];
    private static DateTime _lastGpuUpdate = DateTime.MinValue;

    // Ensure GPU info is only fetched once per second to be performant
    private static Task<List<IHardware>> GetGpuDataAsync()
    {
        if (DateTime.Now - _lastGpuUpdate < TimeSpan.FromSeconds(1))
            return Task.FromResult(Gpus); // Use cached GPU data

        _lastGpuUpdate = DateTime.Now;

        // Initialize OpenHardwareMonitor to fetch hardware data
        var computer = new Computer { GPUEnabled = true };
        computer.Open();
        
        // Query GPU data
        var gpus = computer.Hardware
            .Where(hardware => hardware.HardwareType == HardwareType.GpuNvidia)
            .ToList();

        foreach (var gpu in gpus)
        {
            gpu.Update();
        }

        Gpus.Clear();
        Gpus.AddRange(gpus);
        return Task.FromResult(Gpus);
    }

    // Get GPU usage for all processes - for simplicity, this method assumes one GPU
    public static async Task<double> GetGpuUsageAsync(this System.Diagnostics.Process process)
    {
        // Get GPU data asynchronously
        var gpus = await GetGpuDataAsync();
        
        // Assuming only one GPU is present, or you can select the specific GPU
        var gpu = gpus.FirstOrDefault();
        if (gpu == null)
            return 0;

        // Update and read GPU usage values (percentage)
        foreach (var sensor in gpu.Sensors)
        {
            if (sensor.SensorType == SensorType.Load)
            {
                // GPU usage percentage (0 to 100)
                return sensor.Value ?? 0;
            }
        }

        return 0;
    }
}
*/
