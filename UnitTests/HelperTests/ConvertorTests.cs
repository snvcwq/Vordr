namespace Vordr.UnitTests.HelperTests;

using Xunit;
using Vordr.ResourcesMonitoring.Windows.Hardware;

public class ConvertorTests
{
    [Theory]
    [InlineData(1073741824, 1)]
    [InlineData(2147483648, 2)] 
    [InlineData(536870912, 0.5)]
    [InlineData(0, 0)]
    public void ToGb_ShouldConvertBytesToGigabytes(double input, double expected)
    {
        // Act
        double result = input.ToGb();

        // Assert
        Assert.Equal(expected, result, precision: 5);
    }
    
    
    
}
