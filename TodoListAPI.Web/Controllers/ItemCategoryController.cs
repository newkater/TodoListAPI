using Microsoft.AspNetCore.Mvc;
using TodoListAPI.Domain.Entities;
using TodoListAPI.Infrastructure.Data;

namespace TodoListAPI.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemCategoryController : ControllerBase
{
    private readonly AppDbContext _context;

    public ItemCategoryController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetCategories ()
    {
        var categories = _context.ItemCategories;
        return Ok(categories);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCategory (string name)
    {
        var category = new ItemCategory { Name = name };
        _context.ItemCategories.Add(category);
        await _context.SaveChangesAsync();
        return Ok(category);
    }
}
