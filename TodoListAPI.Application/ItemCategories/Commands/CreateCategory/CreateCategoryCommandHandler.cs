using MediatR;
using TodoListAPI.Application.Common.Interfaces;

namespace TodoListAPI.Application.ItemCategories.Commands.CreateCategory;

internal class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryCommandResponse>
{
    private readonly IApplicationDbContext _context;

    public CreateCategoryCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.ItemCategory newCategory = new(Guid.NewGuid(), request.Name);
        await _context.ItemCategories.AddAsync(newCategory, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return new CreateCategoryCommandResponse(newCategory.Id, newCategory.Name);
    }
}