using MediatR;

namespace TodoListAPI.Application.ItemTags.Queries.GetTags;

public record GetTagsQuery : IRequest<IEnumerable<Domain.Entities.ItemTag>>
{
}
