using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoListAPI.Application.ItemCategories.Commands.CreateCategory;
using TodoListAPI.Application.ItemCategories.Queries.GetCategories;
using TodoListAPI.Web.Models;

namespace TodoListAPI.Web.Controllers;


public class ItemCategoryController : BaseApiController
{
    public ItemCategoryController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<ActionResult> GetCategories()
    {
        var tags = await _mediator.Send(new GetCategoriesQuery());
        return Ok(tags);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCategory(string name)
    {
        var tag = await _mediator.Send(new CreateCategoryCommand(name));
        return Ok(new ItemCategoryModel(tag.Id, tag.Name));
    }
}
