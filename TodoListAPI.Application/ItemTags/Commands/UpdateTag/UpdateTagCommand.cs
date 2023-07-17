using MediatR;
using TodoListAPI.Domain.Common;

namespace TodoListAPI.Application.ItemTags.Commands.UpdateTag;

public record UpdateTagCommand(Guid Id, string Name) : IRequest<Result<UpdateTagCommandResponse>>;
