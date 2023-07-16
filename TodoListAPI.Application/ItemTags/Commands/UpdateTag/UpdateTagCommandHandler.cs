using MediatR;
using TodoListAPI.Application.Common.Interfaces;

namespace TodoListAPI.Application.ItemTags.Commands.UpdateTag;

internal class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, UpdateTagCommandResponse>
{
    private readonly IApplicationDbContext _context;

    public UpdateTagCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<UpdateTagCommandResponse> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var itemTag = await _context.ItemTags.FindAsync(request.Id, cancellationToken);
        if (itemTag == null)
        {
            throw new ArgumentException("tag not found");
        }

        itemTag.Name = request.Name;
        await _context.SaveChangesAsync(cancellationToken);

        return new UpdateTagCommandResponse(itemTag.Id, itemTag.Name);
    }
}
