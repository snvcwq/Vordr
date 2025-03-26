namespace Vordr.UnitTests.HelperTests;
using Xunit;
using Vordr.ResourcesMonitoring.Windows.Convertors;

public class UnitConverterTests
{
    [Theory]
    [InlineData(1024, 1)] // 1024 KB = 1 MB
    [InlineData(2048, 2)] // 2048 KB = 2 MB
    [InlineData(512, 0.5)] // 512 KB = 0.5 MB
    public void KilobytesToMegabytes_ShouldConvertCorrectly(long kilobytes, double expectedMb)
    {
        // Act
        double result = UnitConverter.KilobytesToMegabytes(kilobytes);

        // Assert
        Assert.Equal(expectedMb, result, precision: 5);
    }

    [Theory]
    [InlineData(1_048_576, 1)] // 1,048,576 Bytes = 1 MB
    [InlineData(2_097_152, 2)] // 2,097,152 Bytes = 2 MB
    [InlineData(524_288, 0.5)] // 524,288 Bytes = 0.5 MB
    public void BytesToMb_ShouldConvertCorrectly(long bytes, double expectedMb)
    {
        // Act
        double result = UnitConverter.BytesToMb(bytes);

        // Assert
        Assert.Equal(expectedMb, result, precision: 5);
    }
}
