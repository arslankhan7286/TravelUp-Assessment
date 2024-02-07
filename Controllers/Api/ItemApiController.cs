// Controllers/ItemController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelUp.Data;
using TravelUp.Models;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ItemController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Item
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ItemModel>>> GetItems()
    {
        return await _context.Items.ToListAsync();
    }

    // GET: api/Item/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ItemModel>> GetItem(int id)
    {
        var item = await _context.Items.FindAsync(id);

        if (item == null)
        {
            return NotFound();
        }

        return item;
    }

    // POST: api/Item
    [HttpPost]
    public async Task<ActionResult<ItemModel>> PostItem(ItemModel newItem)
    {
        _context.Items.Add(newItem);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetItem), new { id = newItem.Id }, newItem);
    }

    // PUT: api/Item/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutItem(int id, ItemModel updatedItem)
    {
        if (id != updatedItem.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedItem).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ItemExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Item/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        var item = await _context.Items.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }

        _context.Items.Remove(item);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ItemExists(int id)
    {
        return _context.Items.Any(e => e.Id == id);
    }
}
