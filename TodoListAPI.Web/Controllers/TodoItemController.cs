using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Infrastructure.Data;
using TodoListAPI.Web.Models;

namespace TodoListAPI.Web.Controllers;


public class TodoItemController : BaseApiController
{
    public TodoItemController(IMediator mediator) : base(mediator)
    {
    }
}
