using Application.Common.Enums;
using Application.Features.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Common;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(IMediator mediator, ILogger<UsersController> logger) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        logger.LogInformation("Getting user by id: {Id}", id);
        var result = await mediator.Send(new GetUserByIdRequest(id));
        logger.LogInformation("Get user by id result: {Result}", result.IsSuccess ? "Success" : $"Failure - {result.ErrorType}");
        return result.ToActionResult();
    }
}
