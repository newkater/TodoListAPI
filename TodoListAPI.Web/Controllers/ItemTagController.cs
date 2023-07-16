using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoListAPI.Application.ItemTags.Commands.CreateTag;
using TodoListAPI.Application.ItemTags.Commands.DeleteTag;
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

    [HttpDelete]
    public async Task<ActionResult> DeleteTag(Guid id)
    {
        var result = await _mediator.Send(new DeleteTagCommand(id));
        if (!result.IsDeleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
