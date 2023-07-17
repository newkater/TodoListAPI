using TodoListAPI.Application.Common;

namespace TodoListAPI.Application.ItemTags.Commands.UpdateTag;

public record UpdateTagCommand(Guid Id, string Name) : ICommand<UpdateTagCommandResponse>;
