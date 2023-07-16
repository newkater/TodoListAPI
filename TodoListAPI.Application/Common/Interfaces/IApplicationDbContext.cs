using Microsoft.EntityFrameworkCore;
using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<ItemCategory> ItemCategories { get; }

    DbSet<ItemTag> ItemTags { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
