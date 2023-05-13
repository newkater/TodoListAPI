namespace TodoListAPI.Domain.Entities;

public class ItemTag
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new HashSet<TodoItem>();
}
