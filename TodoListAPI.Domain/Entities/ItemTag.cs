namespace TodoListAPI.Domain.Entities;

public class ItemTag : BaseEntity
{
    public string Name { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new HashSet<TodoItem>();
}
