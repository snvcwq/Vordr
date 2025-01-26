using LanguageExt.Common;
using Microsoft.Extensions.Logging;

namespace Vordr.Application.Common.Behaviours;

public class UnhandledExceptionBehaviour<TRequest, TResponse>(
    ILogger<TRequest> logger
    ):IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch (Exception exception)
        {
           logger.LogError("An exception was caught when executing {@RequestName}. Exception: {@Message}. Stacktrace: {@StackTrace}",
               typeof(TRequest).Name,
               exception.Message,
               exception.StackTrace);
           
           if (!typeof(TResponse).IsGenericType || typeof(TResponse).GetGenericTypeDefinition() != typeof(Result<>))
               throw;

           return (TResponse)Activator.CreateInstance(typeof(TResponse), exception)!;
        }
    }
}
