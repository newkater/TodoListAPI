using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using TodoListAPI.Application.ItemTags.Commands.CreateTag;
using TodoListAPI.Application.ItemTags.Commands.DeleteTag;
using TodoListAPI.Application.ItemTags.Commands.UpdateTag;
using TodoListAPI.Application.ItemTags.Queries.GetTags;
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

    [HttpDelete("id")]
    public async Task<ActionResult> DeleteTag(Guid id)
    {
        var result = await _mediator.Send(new DeleteTagCommand(id));
        if (!result.IsDeleted)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpPut("id")]
    public async Task<ActionResult> UpdateTag(Guid id, string name)
    {
        var result = await _mediator.Send(new UpdateTagCommand(id, name));
        
        return result.Switch(
            value => Ok(value),
            errors => Problem(errors));
    }
}
