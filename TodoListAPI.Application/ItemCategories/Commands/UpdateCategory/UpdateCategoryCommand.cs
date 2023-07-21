using TodoListAPI.Application.Common;

namespace TodoListAPI.Application.ItemCategories.Commands.UpdateCategory;

public record UpdateCategoryCommand(Guid Id, string Name) : ICommand<UpdateCategoryCommandResponse>;
