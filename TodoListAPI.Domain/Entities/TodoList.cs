namespace TodoListAPI.Domain.Entities;

public class TodoList
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
}
