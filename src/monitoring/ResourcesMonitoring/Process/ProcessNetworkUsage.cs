using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Vordr.ResourcesMonitoring.Windows.Process;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
internal class ProcessNetworkUsage
{
    internal long NetworkSentBytes { get; private set; }
    internal long NetworkReceivedBytes { get; private set; }

    private readonly PerformanceCounter _sentCounter;
    private readonly PerformanceCounter _receivedCounter;

    internal ProcessNetworkUsage(System.Diagnostics.Process process)
    {
        if (process == null || process.HasExited)
            throw new ArgumentException("Invalid or exited process.");

        var instanceName = GetProcessInstanceName(process.Id);
        if (instanceName == null)
            throw new InvalidOperationException("Could not find process instance.");

        _sentCounter = new PerformanceCounter("Process", "IO Write Bytes/sec", instanceName);
        _receivedCounter = new PerformanceCounter("Process", "IO Read Bytes/sec", instanceName);
    }

    internal void Update()
    {
        try
        {
            NetworkSentBytes = (long)_sentCounter.NextValue();
            NetworkReceivedBytes = (long)_receivedCounter.NextValue();
        }
        catch (Exception)
        {
            NetworkSentBytes = 0;
            NetworkReceivedBytes = 0;
        }
    }

    private static string GetProcessInstanceName(int processId)
    {
        var category = new PerformanceCounterCategory("Process");
        string[] instanceNames = category.GetInstanceNames();

        foreach (var instance in instanceNames)
        {
            using var counter = new PerformanceCounter("Process", "ID Process", instance, true);
            if ((int)counter.RawValue == processId)
                return instance;
        }

        return string.Empty;
    }
}
