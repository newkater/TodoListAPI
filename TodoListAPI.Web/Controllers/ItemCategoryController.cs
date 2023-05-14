using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Domain.Entities;
using TodoListAPI.Infrastructure.Data;
using TodoListAPI.Web.Models;

namespace TodoListAPI.Web.Controllers;


public class ItemCategoryController : BaseApiController
{
    private readonly AppDbContext _context;

    public ItemCategoryController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetCategories ()
    {
        var categories = await _context.ItemCategories.ToListAsync();
        return Ok(categories);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCategory (string name)
    {
        var category = new ItemCategory { Name = name };
        _context.ItemCategories.Add(category);
        await _context.SaveChangesAsync();
        return Ok(new ItemCategoryModel(category.Id, category.Name));
    }
}
