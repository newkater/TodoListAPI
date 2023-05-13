namespace TodoListAPI.Domain.Entities;

public class ItemCategory
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
}
