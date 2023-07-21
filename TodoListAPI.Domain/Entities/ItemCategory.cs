namespace TodoListAPI.Domain.Entities;

public class ItemCategory : BaseEntity
{
    public ItemCategory(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public string Name { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
}
