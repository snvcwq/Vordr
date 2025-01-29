using System.Text;

namespace Vordr.Application.Common.Extensions;

public static class ErrorExtensions
{
    public static string Print(this List<Error> errors)
    {
        var result = new StringBuilder();
        foreach (var error in errors)
            result.Append($"ErrorType: {error.Type}, Code: {error.Code}, Description: {error.Description}; \n");
        return result.ToString();
    }
}
