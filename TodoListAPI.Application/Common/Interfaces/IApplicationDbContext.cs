using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Application.Common.Interfaces;

internal interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
