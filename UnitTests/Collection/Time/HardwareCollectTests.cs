using System.Diagnostics;
using Vordr.ResourcesMonitoring.Windows.Hardware;

namespace Vordr.UnitTests.Collection.Time;

public class HardwareCollectTests
{
    [Fact]
    public void Collect_ShouldCompleteWithin15Seconds()
    {
        // Arrange
        var collector = new HardwareComponentsCollector();
        var stopwatch = Stopwatch.StartNew();

        // Act
        var result = collector.Collect();
        stopwatch.Stop();

        // Assert
        Assert.NotNull(result); 
        Assert.True(stopwatch.ElapsedMilliseconds <= 15000, 
            $"Collect() took too long: {stopwatch.ElapsedMilliseconds} ms (should be <= 15000 ms)");
    }
    
    [Fact]
    public void Collect_ShouldReturnValidData()
    {
        // Arrange
        var collector = new HardwareComponentsCollector();

        // Act
        var result = collector.Collect();

        // Assert
        Assert.NotNull(result); 
        Assert.NotNull(result.Cpu); 
        Assert.False(string.IsNullOrWhiteSpace(result.Cpu.Name)); 
        Assert.True(result.Cpu.Cores >= 0); 
        
        Assert.NotNull(result.Battery); 
        Assert.NotNull(result.Gpu); 
        Assert.NotNull(result.Network); 
        Assert.NotNull(result.Drives);
    }
    
}
