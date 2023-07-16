using MediatR;
using TodoListAPI.Application.Common.Interfaces;

namespace TodoListAPI.Application.ItemTags.Commands.DeleteTag;

internal class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand, DeleteTagCommandResponse>
{
    private readonly IApplicationDbContext _context;

    public DeleteTagCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<DeleteTagCommandResponse> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
    {
        var itemTag = await _context.ItemTags.FindAsync(request.Id, cancellationToken);
        if (itemTag == null)
        {
            return new DeleteTagCommandResponse(false);
        }

        _context.ItemTags.Remove(itemTag);
        await _context.SaveChangesAsync(cancellationToken);

        return new DeleteTagCommandResponse(true);
    }
}
