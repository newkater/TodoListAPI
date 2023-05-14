using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Infrastructure.Data;
using TodoListAPI.Web.Models;

namespace TodoListAPI.Web.Controllers;


public class TodoItemController : BaseApiController
{
    private readonly AppDbContext _context;

    public TodoItemController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetItems()
    {
        var items = await _context
            .TodoItems
            .Include(i => i.TodoList)
            .Include(i => i.ItemCategory)
            .Include(i => i.ItemTags)
            .Select(item => new TodoItemModel(item.Id,
                                              item.Description,
                                              item.Status,
                                              item.TodoListId,
                                              item.TodoList.Name,
                                              new ItemCategoryModel(item.ItemCategoryId, item.ItemCategory.Name),
                                              item.ItemTags.Select(tag => new ItemTagModel(tag.Id, tag.Name)).ToList()
                                              ))
            .ToListAsync();
        
        return Ok(items);
    }
}
