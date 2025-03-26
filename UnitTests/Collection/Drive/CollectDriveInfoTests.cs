using Vordr.ResourcesMonitoring.Windows.Hardware;

namespace Vordr.UnitTests.Collection.Drive;

public class CollectDriveInfoTests
{
    [Fact]
    public void DriveInformation_ShouldReturnValidData()
    {
        // Arrange
        string existingDrive = "C:";

        // Act
        var driveInfo = new DriveInformation(existingDrive);

        // Assert
        Assert.NotNull(driveInfo);
        Assert.False(string.IsNullOrEmpty(driveInfo.Name));
        Assert.True(driveInfo.TotalSize > 0);
        Assert.True(driveInfo.FreeSpace >= 0);
    }
}
