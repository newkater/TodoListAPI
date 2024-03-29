﻿using Microsoft.EntityFrameworkCore;
using TodoListAPI.Application.Common.Interfaces;
using TodoListAPI.Domain.Entities;

namespace TodoListAPI.Infrastructure.Data;

public class AppDbContext : DbContext, IApplicationDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
    {
    }

    public DbSet<ItemCategory> ItemCategories { get; set; }

    public DbSet<ItemTag> ItemTags { get; set; }

    public DbSet<TodoItem> TodoItems { get; set; }

    public DbSet<TodoList> TodoLists { get; set; }
}
