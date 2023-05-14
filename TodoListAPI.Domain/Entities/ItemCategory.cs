namespace TodoListAPI.Domain.Entities;

public class ItemCategory : BaseEntity
{
    public string Name { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
}
