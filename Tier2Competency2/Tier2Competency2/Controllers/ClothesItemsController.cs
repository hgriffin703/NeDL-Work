using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tier2Competency2.Models;

namespace Tier2Competency2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesItemsController : ControllerBase
    {
        private readonly ClothesContext _context;

        public ClothesItemsController(ClothesContext context)
        {
            _context = context;
        }

        // GET: api/ClothesItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClothesItems>>> GetClothesItem()
        {
            return await _context.ClothesItems.ToListAsync();
        }

        // GET: api/ClothesItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClothesItems>> GetClothesItem(long id)
        {
            var clothesItems = await _context.ClothesItems.FindAsync(id);

            if (clothesItems == null)
            {
                return NotFound();
            }

            return clothesItems;
        }

        // PUT: api/ClothesItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClothesItems(long id, ClothesItems clothesItems)
        {
            if (id != clothesItems.Id)
            {
                return BadRequest();
            }

            _context.Entry(clothesItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClothesItemsExists(id))
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

        // POST: api/ClothesItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClothesItems>> PostClothesItems(ClothesItems clothesItems)
        {
            _context.ClothesItems.Add(clothesItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClothesItem), new { id = clothesItems.Id }, clothesItems);
        }

        // DELETE: api/ClothesItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClothesItems(long id)
        {
            var clothesItems = await _context.ClothesItems.FindAsync(id);
            if (clothesItems == null)
            {
                return NotFound();
            }

            _context.ClothesItems.Remove(clothesItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClothesItemsExists(long id)
        {
            return _context.ClothesItems.Any(e => e.Id == id);
        }
    }
}
