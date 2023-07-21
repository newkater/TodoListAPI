using MediatR;

namespace TodoListAPI.Application.ItemCategories.Queries.GetCategories;

public record GetCategoriesQuery : IRequest<IEnumerable<Domain.Entities.ItemCategory>>
{
}
