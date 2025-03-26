using MongoDB.Bson;
using Moq;
using Vordr.Application.Battery.Queries;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.UnitTests.CQRS.CqrsTests;

public class GetBatteryUsageQueryHandlerTests
{
    private readonly Mock<IPowerSupplyRepository> _mockRepository;
    private readonly GetBatteryUsageQueryHandler _handler;

    public GetBatteryUsageQueryHandlerTests()
    {
        _mockRepository = new Mock<IPowerSupplyRepository>();
        _handler = new GetBatteryUsageQueryHandler(_mockRepository.Object);
    }

    [Fact]
    public async Task Handle_ShouldReturnBatteryUsage_WhenCalled()
    {
        // Arrange
        var query = new GetBatteryUsageQuery();
        var expectedBatteryData = new List<PowerSupply>
        {
            new PowerSupply { Id = ObjectId.GenerateNewId(), DegradationLevel = 9, ChargeLevel = 60 }
        };
        expectedBatteryData.Add(new PowerSupply
        {
            Id = ObjectId.GenerateNewId(),
            ChargeLevel = 80,
            DegradationLevel = 0
        });

        _mockRepository
            .Setup(repo => repo.Retrieve(query))
            .ReturnsAsync(expectedBatteryData);

        // Act
        var result = await _handler.Handle(query, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedBatteryData.Count, result.Count());
        Assert.Equal(expectedBatteryData, result);

        _mockRepository.Verify(repo => repo.Retrieve(query), Times.Once);
    }

    [Fact]
    public async Task Handle_ShouldReturnEmptyList_WhenNoDataFound()
    {
        // Arrange
        var query = new GetBatteryUsageQuery();

        _mockRepository
            .Setup(repo => repo.Retrieve(query))
            .ReturnsAsync(new List<PowerSupply>()); // Empty list

        // Act
        var result = await _handler.Handle(query, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.Empty(result);

        _mockRepository.Verify(repo => repo.Retrieve(query), Times.Once);
    }
}
