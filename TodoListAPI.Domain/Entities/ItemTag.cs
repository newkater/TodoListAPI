namespace TodoListAPI.Domain.Entities;

public class ItemTag : BaseEntity
{
    public ItemTag(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public string Name { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new HashSet<TodoItem>();
}
