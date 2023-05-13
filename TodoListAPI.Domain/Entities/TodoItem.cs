using TodoListAPI.Domain.Enums;

namespace TodoListAPI.Domain.Entities;

public class TodoItem
{
    public Guid Id { get; set; }

    public string Description { get; set; }

    public ItemStatus Status { get; set; }

    public TodoList TodoList { get; set; }

    public Guid TodoListId { get; set; }

    public ItemCategory ItemCategory { get; set; }

    public Guid ItemCategoryId { get; set; }

    public ICollection<ItemTag> ItemTags { get; set; } = new HashSet<ItemTag>();
}
