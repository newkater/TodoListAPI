using TodoListAPI.Domain.Entities;
using TodoListAPI.Domain.Interfaces;
using TodoListAPI.Infrastructure.Data;

namespace TodoListAPI.Infrastructure.Repositories;

public class TodoListRepository : BaseRepository<TodoList>, ITodoListRepository
{
    public TodoListRepository(AppDbContext context) : base(context)
    {
    }
}
