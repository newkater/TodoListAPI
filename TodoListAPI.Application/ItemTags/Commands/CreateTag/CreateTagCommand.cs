using MediatR;

namespace TodoListAPI.Application.ItemTag.Commands.CreateTag;

public record CreateTagCommand (string Name) : IRequest<CreateTagCommandResponse>;