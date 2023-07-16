using MediatR;

namespace TodoListAPI.Web.Controllers;


public class TodoItemController : BaseApiController
{
    public TodoItemController(IMediator mediator) : base(mediator)
    {
    }
}
