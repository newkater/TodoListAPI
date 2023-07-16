using MediatR;

namespace TodoListAPI.Application.ItemTags.Commands.CreateTag;

public record CreateTagCommand (string Name) : IRequest<CreateTagCommandResponse>;