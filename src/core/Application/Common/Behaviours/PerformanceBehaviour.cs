using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Vordr.Application.Common.Behaviours;

public class PerformanceBehaviour<TRequest, TResponse> (
    ILogger<TRequest> logger
    ): IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
{
    private readonly Stopwatch _timer = new();

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _timer.Start();
        var response = await next();

        var elapsedMilliseconds = _timer.ElapsedMilliseconds;
        
        if (elapsedMilliseconds <= 500)
            return response;

        var requestName = typeof(TRequest).Name;

        logger.LogWarning("Found a heavy request {@RequestName}. It took {@ElapsedMilliseconds} milliseconds.", 
            requestName, 
            elapsedMilliseconds);
        return response;
    }
}
