using MediatR;

namespace TodoListAPI.Application.ItemCategories.Commands.DeleteCategory;

public record DeleteCategoryCommand(Guid Id) : IRequest<DeleteCategoryCommandResponse>;
