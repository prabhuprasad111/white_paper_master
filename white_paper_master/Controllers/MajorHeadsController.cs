using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using white_paper_master.Models;

namespace white_paper_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MajorHeadsController : ControllerBase
    {
        private readonly WhitePaperDbContext _context;

        public MajorHeadsController(WhitePaperDbContext context)
        {
            _context = context;
        }

        // GET: api/MajorHeads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OdWpCbTotalCog>>> GetOdWpCbTotalCogs()
        {
            return await _context.OdWpCbTotalCogs.ToListAsync();
        }

        // GET: api/MajorHeads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OdWpCbTotalCog>> GetOdWpCbTotalCog(int id)
        {
            var odWpCbTotalCog = await _context.OdWpCbTotalCogs.FindAsync(id);

            if (odWpCbTotalCog == null)
            {
                return NotFound();
            }

            return odWpCbTotalCog;
        }

        // PUT: api/MajorHeads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOdWpCbTotalCog(int id, OdWpCbTotalCog odWpCbTotalCog)
        {
            if (id != odWpCbTotalCog.SlNo)
            {
                return BadRequest();
            }

            _context.Entry(odWpCbTotalCog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OdWpCbTotalCogExists(id))
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

        // POST: api/MajorHeads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OdWpCbTotalCog>> PostOdWpCbTotalCog(OdWpCbTotalCog odWpCbTotalCog)
        {
            _context.OdWpCbTotalCogs.Add(odWpCbTotalCog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOdWpCbTotalCog", new { id = odWpCbTotalCog.SlNo }, odWpCbTotalCog);
        }

        // DELETE: api/MajorHeads/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOdWpCbTotalCog(int id)
        {
            var odWpCbTotalCog = await _context.OdWpCbTotalCogs.FindAsync(id);
            if (odWpCbTotalCog == null)
            {
                return NotFound();
            }

            _context.OdWpCbTotalCogs.Remove(odWpCbTotalCog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OdWpCbTotalCogExists(int id)
        {
            return _context.OdWpCbTotalCogs.Any(e => e.SlNo == id);
        }
    }
}
