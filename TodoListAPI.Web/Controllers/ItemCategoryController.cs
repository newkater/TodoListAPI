using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Domain.Entities;
using TodoListAPI.Infrastructure.Data;
using TodoListAPI.Web.Models;

namespace TodoListAPI.Web.Controllers;


public class ItemCategoryController : BaseApiController
{
    public ItemCategoryController(IMediator mediator) : base(mediator)
    {
    }
}
