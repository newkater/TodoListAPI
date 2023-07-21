using MediatR;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Application.Common.Interfaces;
using TodoListAPI.Application.ItemTags.Queries.GetTags;
using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Application.ItemCategories.Queries.GetCategories;

internal class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, IEnumerable<Domain.Entities.ItemCategory>>
{
    private readonly IApplicationDbContext _context;

    public GetCategoriesQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ItemCategory>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        return await _context.ItemCategories.ToListAsync(cancellationToken);
    }
}
