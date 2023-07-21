using MediatR;
using TodoListAPI.Application.Common.Interfaces;

namespace TodoListAPI.Application.ItemCategories.Commands.DeleteCategory;

internal class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, DeleteCategoryCommandResponse>
{
    private readonly IApplicationDbContext _context;

    public DeleteCategoryCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var itemCategory = await _context.ItemCategories.FindAsync(request.Id, cancellationToken);
        if (itemCategory == null)
        {
            return new DeleteCategoryCommandResponse(false);
        }

        _context.ItemCategories.Remove(itemCategory);
        await _context.SaveChangesAsync(cancellationToken);

        return new DeleteCategoryCommandResponse(true);
    }
}
