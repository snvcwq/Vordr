using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Common.Behaviours;

public class LoggingBehaviour<TRequest, TResponse>(ILogger<TRequest> logger) : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;
        logger.LogInformation($"Handling request: {requestName}");

        var response = await next();

        logger.LogInformation($"Request handled: {requestName}");

        return response;
    }
}
