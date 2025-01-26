using LanguageExt.Common;
using Microsoft.AspNetCore.Mvc;

namespace Vordr.Web.Controllers;

public class BaseController : ControllerBase
{
    protected IActionResult MapResult<T>(Result<T> result)
    {
        return result.Match<IActionResult>(
            m => Ok(m),
            error => BadRequest(error.Message));
    }
}
