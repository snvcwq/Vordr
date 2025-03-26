using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using Vordr.Application.Common.Behaviours;

namespace Vordr.UnitTests.BehavioursHets;

public class LoggingTests
{
    private readonly Mock<ILogger<TestRequest>> _mockLogger;
    private readonly LoggingBehaviour<TestRequest, TestResponse> _loggingBehaviour;

    public LoggingTests()
    {
        _mockLogger = new Mock<ILogger<TestRequest>>();
        _loggingBehaviour = new LoggingBehaviour<TestRequest, TestResponse>(_mockLogger.Object);
    }

    [Fact]
    public async Task Handle_ShouldLogBeforeAndAfterProcessing()
    {
        // Arrange
        var request = new TestRequest();
        var response = new TestResponse();
        var cancellationToken = CancellationToken.None;

        RequestHandlerDelegate<TestResponse> next = () => Task.FromResult(response);

        // Act
        var result = await _loggingBehaviour.Handle(request, next, cancellationToken);

        // Assert
        Assert.Equal(response, result);

        _mockLogger.Verify(
            x => x.Log(
                LogLevel.Information,
                It.IsAny<EventId>(),
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Handling request")),
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                It.IsAny<Exception>(),
                It.Is<Func<It.IsAnyType, Exception?, string>>((v, t) => true)),
            Times.Once);

        _mockLogger.Verify(
            x => x.Log(
                LogLevel.Information,
                It.IsAny<EventId>(),
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Request handled")),
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                It.IsAny<Exception>(),
                It.Is<Func<It.IsAnyType, Exception?, string>>((v, t) => true)),
            Times.Once);
    }

    public class TestRequest { }
    public class TestResponse { }
}
