using MediatR;
using TodoListAPI.Application.Common.Interfaces;
using TodoListAPI.Domain.Common;
using TodoListAPI.Domain.Errors;

namespace TodoListAPI.Application.ItemTags.Commands.UpdateTag;

internal class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, Result<UpdateTagCommandResponse>>
{
    private readonly IApplicationDbContext _context;

    public UpdateTagCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<UpdateTagCommandResponse>> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var itemTag = await _context.ItemTags.FindAsync(request.Id, cancellationToken);
        if (itemTag == null)
        {
            return ItemTagErrors.NotFound(request.Id);
        }

        itemTag.Name = request.Name;
        await _context.SaveChangesAsync(cancellationToken);

        return new UpdateTagCommandResponse(itemTag.Id, itemTag.Name);
    }
}
