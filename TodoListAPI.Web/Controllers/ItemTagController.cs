using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Domain.Entities;
using TodoListAPI.Infrastructure.Data;
using TodoListAPI.Web.Models;

namespace TodoListAPI.Web.Controllers;


public class ItemTagController : BaseApiController
{
    private readonly AppDbContext _context;

    public ItemTagController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetTags()
    {
        var tags = await _context.ItemTags.ToListAsync();
        return Ok(tags);
    }

    [HttpPost]
    public async Task<ActionResult> CreateTag(string name)
    {
        var tag = new ItemTag { Name = name };
        _context.Add(tag);
        await _context.SaveChangesAsync();
        return Ok(new ItemTagModel(tag.Id, tag.Name));
    }
}
