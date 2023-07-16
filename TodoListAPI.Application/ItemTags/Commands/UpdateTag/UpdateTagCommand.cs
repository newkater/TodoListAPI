using MediatR;

namespace TodoListAPI.Application.ItemTags.Commands.UpdateTag;

public record UpdateTagCommand(Guid Id, string Name) : IRequest<UpdateTagCommandResponse>;
