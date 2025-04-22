namespace Vordr.ResourcesMonitoring.Windows;

public static class RetryPolicy
{
    public static void ExecuteWithRetry(Action action, int maxRetries = 3, int delayMilliseconds = 10)
    {
        var retryCount = 0;
        
        while (retryCount < maxRetries)
        {
            try
            {
                action();
                return;
            }
            catch (Exception ex)
            {
                retryCount++;
                Console.WriteLine($"Attempt {retryCount} failed: {ex.Message}");
                
                if (retryCount >= maxRetries)
                {
                    Console.WriteLine("Max retry attempts reached. Operation failed.");
                    throw;
                }

                Console.WriteLine($"Retrying in {delayMilliseconds} ms...");
                Thread.Sleep(delayMilliseconds);
            }
        }
    }
}
