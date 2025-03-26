
using Vordr.Application.Models.Process;
using Vordr.ResourcesMonitoring.Windows.Process;
using Vordr.ResourcesMonitoring.Windows.Process.Properties;

namespace Vordr.UnitTests.Collection.Process;

public class ProcessTests
{
    [Fact]
    public void GetIcon_ShouldReturnNull_ForInvalidProcess()
    {
        // Arrange: 
        using var process = System.Diagnostics.Process.GetCurrentProcess();

        // Act:
        var iconBytes = process.GetIcon();

        // Assert:
        Assert.NotNull(iconBytes);
    }
    
    private readonly ProcessDataCollector _collector = new();

    [Fact]
    public async Task GetCurrentProcesses_ShouldReturnProcesses()
    {
        // Act
        var processes = await _collector.GetCurrentProcesses();

        // Assert
        Assert.NotNull(processes);
        Assert.NotEmpty(processes);
        Assert.All(processes, process =>
        {
            Assert.NotNull(process.Name);
        });
    }

    [Fact]
    public void GetProcessInfoAsync_ShouldReturnProcessInfo_ForValidProcess()
    {
        // Arrange
        using var process = System.Diagnostics.Process.GetCurrentProcess();

        // Act
        var processInfo = ProcessDataCollector.GetProcessInfoAsync(process, CancellationToken.None);

        // Assert
        Assert.NotNull(processInfo);
        Assert.Equal(process.Id, processInfo!.Pid);
        Assert.Equal(process.ProcessName, processInfo.Name);
    }

    [Fact]
    public void GetProcessInfoAsync_ShouldReturnNull_ForInvalidProcess()
    {
        // Arrange
        var invalidProcess = new System.Diagnostics.Process(); 

        // Act
        var processInfo = typeof(ProcessDataCollector)
            .GetMethod("GetProcessInfoAsync", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)?
            .Invoke(null, [invalidProcess, default]) as ProcessInformation;

        // Assert
        Assert.Null(processInfo);
    }

    [Fact]
    public void GroupProcesses_ShouldMergeProcessesCorrectly()
    {
        // Arrange
        var processes = new List<ProcessInformation>
        {
            new ProcessInformation
            {
                Name = "TestProcess",
                Path = "/test",
                Company = "TestCorp",
                Version = "1.0",
                CpuUsage = 15,
                RamUsage = 300,
                ThreadCount = 7,
                HandleCount = 12,
                Pid = 0,
                StartTime = default,
                Priority = 0,
                Architecture = "x86",
                IsSystemProcess = false
            }
        };
        processes.Add(new ProcessInformation
        {
            Name = "TestProcess",
            Path = "/test",
            Company = "TestCorp",
            Version = "1.0",
            CpuUsage = 10,
            RamUsage = 200,
            ThreadCount = 5,
            HandleCount = 10,
            Pid = 0,
            StartTime = default,
            Priority = 0,
            Architecture = "x86",
            IsSystemProcess = false
        });

        var method = typeof(ProcessDataCollector)
            .GetMethod("GroupProcesses", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);

        // Act
        var groupedProcesses = method?.Invoke(null, new object[] { processes }) as List<ProcessInformation>;

        // Assert
        Assert.NotNull(groupedProcesses);
        Assert.Single(groupedProcesses);
        var mergedProcess = groupedProcesses!.First();
        Assert.Equal(25, mergedProcess.CpuUsage);
        Assert.Equal(500, mergedProcess.RamUsage);
        Assert.Equal(12, mergedProcess.ThreadCount);
        Assert.Equal(22, mergedProcess.HandleCount);
    }
}
