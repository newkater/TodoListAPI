using MediatR;

namespace TodoListAPI.Application.ItemTags.Commands.DeleteTag;

public record DeleteTagCommand(Guid Id) : IRequest<DeleteTagCommandResponse>;
