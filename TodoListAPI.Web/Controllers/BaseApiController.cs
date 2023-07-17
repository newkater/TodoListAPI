using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoListAPI.Domain.Common;

namespace TodoListAPI.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseApiController : ControllerBase
{
    protected readonly IMediator _mediator;

    public BaseApiController(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected ActionResult Problem(IEnumerable<Error> errors)
    {
        var error = errors.First();
        return Problem(statusCode: (int)error.StatusCode, title: error.Message);
    }
}
