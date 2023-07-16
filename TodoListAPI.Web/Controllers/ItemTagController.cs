using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Application.ItemTag.Commands.CreateTag;
using TodoListAPI.Application.ItemTag.Queries.GetTags;
using TodoListAPI.Domain.Entities;
using TodoListAPI.Infrastructure.Data;
using TodoListAPI.Web.Models;

namespace TodoListAPI.Web.Controllers;


public class ItemTagController : BaseApiController
{
    public ItemTagController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<ActionResult> GetTags()
    {
        var tags = await _mediator.Send(new GetTagsQuery());
        return Ok(tags);
    }

    [HttpPost]
    public async Task<ActionResult> CreateTag(string name)
    {
        var tag = await _mediator.Send(new CreateTagCommand(name));
        return Ok(new ItemTagModel(tag.Id, tag.Name));
    }
}
