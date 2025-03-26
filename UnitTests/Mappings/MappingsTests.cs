using MongoDB.Bson;
using Vordr.Application.Common.Mappings.HardwareMetrics;
using Vordr.Application.Common.Mappings.Process;
using Vordr.Application.Models.Hardware.Components;
using Vordr.Application.Models.Process;

namespace Vordr.UnitTests.Mappings;

public class MappingsTests
{
    [Fact]
    public void ToCpuLoad_ShouldMapCpuReportToCpuLoadCorrectly()
    {
        // Arrange
        var report = new CpuReport
        {
            AvgUsage = 45.5,
            Temperature = 60.5,
            CapturedAtUtc = new DateTime(2025, 3, 26, 14, 30, 0, DateTimeKind.Utc)
        };

        // Act
        var result = report.ToCpuLoad();

        // Assert
        Assert.Equal(report.AvgUsage, result.LoadPercents);
        Assert.Equal(report.Temperature, result.Temperature);
        Assert.Equal(report.CapturedAtUtc, result.CapturedAtUtc);
    }
    
    [Fact]
    public void ToDriveInformation_ShouldMapDriveReportToDriveInformationCorrectly()
    {
        // Arrange
        var report = new DriveReport("C:", 500.75,  1000.00, DateTime.Now);

        // Act
        var result = report.ToDriveInformation();

        // Assert
        Assert.Equal(report.DriveName, result.DriveName);
        Assert.Equal(report.DriveFreeSpace, result.DriveFreeSpaceGb); 
        Assert.Equal(report.DriveTotalSize, result.DriveTotalSizeGb);
    }
    
    [Fact]
    public void ToGpuLoad_ShouldMapGpuReportToGpuLoadCorrectly()
    {
        // Arrange
        var report = new GpuReport
        {
            AvgLoad = 75.5, 
            Clock = 1500,  
            Temperature = 65,
            CapturedAtUtc = DateTime.UtcNow
        };

        // Act
        var result = report.ToGpuLoad();

        // Assert
        Assert.Equal(report.AvgLoad, result.LoadPercentage);
        Assert.Equal(report.Clock, result.Clock);
        Assert.Equal(report.Temperature, result.Temperature); 
        Assert.Equal(report.CapturedAtUtc, result.CapturedAtUtc);
    }
    
    [Fact]
    public void ToNetworkInformation_ShouldMapNetworkReportToNetworkInformationCorrectly()
    {
        // Arrange
        var report = new NetworkReport
        {
            Network = "Ethernet",
            DataUploaded = 5000, 
            DataDownloaded = 10000, 
            DownloadSpeed = 100.5, 
            UploadSpeed = 50.2 
        };

        // Act
        var result = report.ToNetworkInformation();

        // Assert
        Assert.Equal(report.Network, result.Network);
        Assert.Equal(report.DataUploaded, result.DataUploaded);
        Assert.Equal(report.DataDownloaded, result.DataDownloaded);
        Assert.Equal(report.DownloadSpeed, result.DownloadSpeed); 
        Assert.Equal(report.UploadSpeed, result.UploadSpeed);
    }
    
    [Fact]
    public void ToProcessMetrics_ShouldMapProcessStatsToProcessMetricsCorrectly()
    {
        // Arrange
        var processStats = new ProcessStats
        {
            CpuUsage = 45.5,
            RamUsage = 512000000, // in bytes
            ThreadCount = 20,
            HandleCount = 150
        };

        var processId = ObjectId.GenerateNewId(); 

        // Act
        var result = processStats.ToProcessMetrics(processId);

        // Assert
        Assert.Equal(processId, result.ProcessObjectId); 
        Assert.Equal(processStats.CpuUsage, result.CpuUsage);
        Assert.Equal(processStats.RamUsage, result.RamUsage); 
        Assert.Equal(processStats.ThreadCount, result.ThreadCount);
        Assert.Equal(processStats.HandleCount, result.HandleCount);
        Assert.True(result.LastModifiedUtc <= DateTime.UtcNow);
    }
    
}
