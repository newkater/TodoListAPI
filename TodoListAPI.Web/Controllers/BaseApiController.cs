﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

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
}
