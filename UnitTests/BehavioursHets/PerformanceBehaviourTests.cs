using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using Vordr.Application.Common.Behaviours;

namespace Vordr.UnitTests.BehavioursHets;

public class PerformanceBehaviourTests
{
    private readonly Mock<ILogger<TestRequest>> _mockLogger;
    private readonly PerformanceBehaviour<TestRequest, TestResponse> _performanceBehaviour;

    public PerformanceBehaviourTests()
    {
        _mockLogger = new Mock<ILogger<TestRequest>>();
        _performanceBehaviour = new PerformanceBehaviour<TestRequest, TestResponse>(_mockLogger.Object);
    }

    [Fact]
    public async Task Handle_ShouldLogWarning_WhenRequestTakesLongerThan500ms()
    {
        // Arrange
        var request = new TestRequest();
        var response = new TestResponse();
        var cancellationToken = CancellationToken.None;

        RequestHandlerDelegate<TestResponse> next = async () =>
        {
            await Task.Delay(600); 
            return response;
        };

        var result = await _performanceBehaviour.Handle(request, next, cancellationToken);

        Assert.Equal(response, result);

        _mockLogger.Verify(
            x => x.Log(
                LogLevel.Warning,
                It.IsAny<EventId>(),
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Found a heavy request")),
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                It.IsAny<Exception>(),
                It.Is<Func<It.IsAnyType, Exception?, string>>((v, t) => true)),
            Times.Once);
    }

    [Fact]
    public async Task Handle_ShouldNotLog_WhenRequestTakesLessThan500ms()
    {
        // Arrange
        var request = new TestRequest();
        var response = new TestResponse();
        var cancellationToken = CancellationToken.None;

        RequestHandlerDelegate<TestResponse> next = async () =>
        {
            await Task.Delay(200);
            return response;
        };

        // Act
        var result = await _performanceBehaviour.Handle(request, next, cancellationToken);

        // Assert
        Assert.Equal(response, result);

        _mockLogger.Verify(
            x => x.Log(
                LogLevel.Warning,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Never);
    }

    public class TestRequest { }
    public class TestResponse { }
}
