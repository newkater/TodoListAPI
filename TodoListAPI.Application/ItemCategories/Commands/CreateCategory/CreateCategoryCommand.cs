using MediatR;

namespace TodoListAPI.Application.ItemCategories.Commands.CreateCategory;

public record CreateCategoryCommand (string Name) : IRequest<CreateCategoryCommandResponse>;
