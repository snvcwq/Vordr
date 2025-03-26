using Vordr.ResourcesMonitoring.Windows;

namespace Vordr.UnitTests.HelperTests;

public class RoundTests
{
    [Theory]
    [InlineData(3.14159f, 2, 3.14)]
    [InlineData(2.678f, 2, 2.68)]
    [InlineData(-1.235f, 2, -1.24)]
    [InlineData(1.555f, 2, 1.55)]
    [InlineData(9.999f, 2, 10.00)]
    public void RoundUp_Float_ShouldRoundCorrectly(float input, int digits, double expected)
    {
        var result = input.RoundUp(digits);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3.14159265358979, 3, 3.142)]
    [InlineData(-1.23456789, 4, -1.2346)]
    [InlineData(2.5555, 2, 2.56)]
    [InlineData(0.9999, 2, 1.00)]
    [InlineData(-0.5555, 3, -0.556)]
    public void RoundUp_Double_ShouldRoundCorrectly(double input, int digits, double expected)
    {
        var result = input.RoundUp(digits);
        Assert.Equal(expected, result);
    }
}
