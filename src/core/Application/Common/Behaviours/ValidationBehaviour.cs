using LanguageExt.Common;
using ValidationException = CleanArchitecture.Application.Common.Exceptions.ValidationException;

namespace CleanArchitecture.Application.Common.Behaviours;

public class ValidationBehaviour<TRequest, TResponse>(
    IEnumerable<IValidator<TRequest>> validators
    ):IPipelineBehavior<TRequest, TResponse> where TRequest : notnull where TResponse : new()
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!validators.Any())
            return await next();
        
        var context = new ValidationContext<TRequest>(request);
        var validationResult = await Task.WhenAll(
            validators.Select(v =>
                v.ValidateAsync(context, cancellationToken)));

        var failures = validationResult
            .Where(r => r.Errors.Count != 0)
            .SelectMany(r => r.Errors).ToList();

        if (failures.Count == 0)
            return await next();

        var exception = new ValidationException(failures);
        if (!typeof(TResponse).IsGenericType || typeof(TResponse).GetGenericTypeDefinition() != typeof(Result<>))
            throw exception;
        
        return (TResponse)Activator.CreateInstance(typeof(TResponse), exception)!;
    }
}
