using Vordr.Domain.Constants;
using ValidationException = Vordr.Application.Common.Exceptions.ValidationException;

namespace Vordr.Application.Common.Behaviours;

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

        if (!typeof(TResponse).IsGenericType || typeof(TResponse).GetGenericTypeDefinition() != typeof(ErrorOr<>))
            throw new ValidationException(failures);

        List<Error> errors = [];
        foreach (var failure in failures)
        {
            errors.Add(
                Error.Validation(failure.ErrorCode,
                    failure.ErrorMessage,
                    new Dictionary<string, object>
                    {
                        { ValidationConstants.AttemptedValue, failure.AttemptedValue },
                        { ValidationConstants.Severity, failure.Severity },
                        { ValidationConstants.PropertyName, failure.PropertyName }
                    }));
        }
        return (TResponse)(object)errors;
    }
}
