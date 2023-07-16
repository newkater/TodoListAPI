using MediatR;
using TodoListAPI.Application.Common.Interfaces;

namespace TodoListAPI.Application.ItemTags.Commands.CreateTag;

internal class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, CreateTagCommandResponse>
{
    private readonly IApplicationDbContext _context;

    public CreateTagCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CreateTagCommandResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.ItemTag newTag = new(Guid.NewGuid(), request.Name);
        await _context.ItemTags.AddAsync(newTag, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return new CreateTagCommandResponse(newTag.Id, newTag.Name);
    }
}
