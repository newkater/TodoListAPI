using MediatR;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Application.Common.Interfaces;

namespace TodoListAPI.Application.ItemTags.Queries.GetTags;

internal class GetTagsQueryHandler : IRequestHandler<GetTagsQuery, IEnumerable<Domain.Entities.ItemTag>>
{
    private readonly IApplicationDbContext _context;

    public GetTagsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Domain.Entities.ItemTag>> Handle(GetTagsQuery request, CancellationToken cancellationToken)
    {
        return await _context.ItemTags.ToListAsync(cancellationToken);
    }
}
