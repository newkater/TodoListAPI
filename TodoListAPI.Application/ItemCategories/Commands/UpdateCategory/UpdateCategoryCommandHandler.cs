using MediatR;
using TodoListAPI.Application.Common.Interfaces;
using TodoListAPI.Domain.Common;
using TodoListAPI.Domain.Errors;

namespace TodoListAPI.Application.ItemCategories.Commands.UpdateCategory;

internal class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Result<UpdateCategoryCommandResponse>>
{
    private readonly IApplicationDbContext _context;

    public UpdateCategoryCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<UpdateCategoryCommandResponse>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var itemCategory = await _context.ItemCategories.FindAsync(request.Id, cancellationToken);
        if (itemCategory == null)
        {
            return ItemCategoryErrors.NotFound(request.Id);
        }

        itemCategory.Name = request.Name;
        await _context.SaveChangesAsync(cancellationToken);

        return new UpdateCategoryCommandResponse(itemCategory.Id, itemCategory.Name);
    }
}
