using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Domain.Interfaces;

public interface ITodoListRepository : IRepository<TodoList>
{
}
