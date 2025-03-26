using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.ResourcesMonitoring.Windows;

namespace Vordr.UnitTests.HelperTests;

public class DependencyInjectionTests
{
    [Fact]
    public void AddWindowsResourceCollectors_ShouldRegisterAllServices()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        services.AddWindowsResourceCollectors();
        var provider = services.BuildServiceProvider();

        // Assert
        Assert.NotNull(provider.GetService<IProcessDataCollector>());
        Assert.NotNull(provider.GetService<IHardwareCollector>());
        Assert.NotNull(provider.GetService<IHardwareComponentsCollector>());
    }

    [Fact]
    public void AddWindowsResourceCollectors_ShouldRegisterServices_AsScoped()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddWindowsResourceCollectors();
        var provider = services.BuildServiceProvider();

        // Act & Assert
        using (var scope1 = provider.CreateScope())
        using (var scope2 = provider.CreateScope())
        {
            var processCollector1 = scope1.ServiceProvider.GetService<IProcessDataCollector>();
            var processCollector2 = scope2.ServiceProvider.GetService<IProcessDataCollector>();

            var hardwareCollector1 = scope1.ServiceProvider.GetService<IHardwareCollector>();
            var hardwareCollector2 = scope2.ServiceProvider.GetService<IHardwareCollector>();

            Assert.NotNull(processCollector1);
            Assert.NotNull(processCollector2);
            Assert.NotNull(hardwareCollector1);
            Assert.NotNull(hardwareCollector2);

            Assert.NotSame(processCollector1, processCollector2);
            Assert.NotSame(hardwareCollector1, hardwareCollector2);
        }
    }
}
