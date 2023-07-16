using MediatR;

namespace TodoListAPI.Web.Controllers;


public class ItemCategoryController : BaseApiController
{
    public ItemCategoryController(IMediator mediator) : base(mediator)
    {
    }
}
