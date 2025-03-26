
using Vordr.ResourcesMonitoring.Windows;

namespace Vordr.UnitTests.HelperTests
{
    public class RetryPolicyTests
    {
        [Fact]
        public void ExecuteWithRetry_ShouldExecuteSuccessfully_OnFirstTry()
        {
            // Arrange
            var executionCount = 0;
            
            void ActionToExecute()
            {
                executionCount++;
            }

            // Act
            RetryPolicy.ExecuteWithRetry(ActionToExecute);

            // Assert
            Assert.Equal(1, executionCount);
        }

        [Fact]
        public void ExecuteWithRetry_ShouldRetry_AndSucceed()
        {
            // Arrange
            var executionCount = 0;

            void ActionToExecute()
            {
                executionCount++;
                if (executionCount < 2) // Fail once, then succeed
                {
                    throw new Exception("Temporary failure.");
                }
            }

            // Act
            RetryPolicy.ExecuteWithRetry(ActionToExecute, maxRetries: 3);

            // Assert
            Assert.Equal(2, executionCount);
        }

        [Fact]
        public void ExecuteWithRetry_ShouldThrowException_AfterMaxRetries()
        {
            // Arrange
            var executionCount = 0;
            
            void ActionToExecute()
            {
                executionCount++;
                throw new Exception("Persistent failure.");
            }

            // Act & Assert
            var ex = Assert.Throws<Exception>(() =>
                RetryPolicy.ExecuteWithRetry(ActionToExecute, maxRetries: 3));

            Assert.Equal("Persistent failure.", ex.Message);
            Assert.Equal(3, executionCount); // Should have retried 3 times
        }
    }
}
