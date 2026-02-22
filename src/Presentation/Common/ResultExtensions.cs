using Application.Common.Enums;
using Application.Common.Results;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Common;

public static class ResultExtensions
{
    public static IActionResult ToActionResult<T>(this Result<T> result)
    {
        if (result.IsSuccess)
            return new OkObjectResult(result.Value);

        return result.ErrorType switch
        {
            ErrorType.Conflict => new ConflictObjectResult(result.ErrorType),
            ErrorType.Validation => new BadRequestObjectResult(result.ErrorType),
            ErrorType.Unauthorized => new UnauthorizedObjectResult(result.ErrorType),
            ErrorType.NotFound => new NotFoundObjectResult(result.ErrorType),
            _ => new ObjectResult(result.ErrorType) { StatusCode = 500 }
        };
    }
}
