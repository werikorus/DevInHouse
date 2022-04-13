using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practiceAPI.Context;
using practiceAPI.Models;

namespace practiceAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroAutorsController : ControllerBase
    {
        private readonly LivrariaContext _context;

        public LivroAutorsController(LivrariaContext context)
        {
            _context = context;
        }

        // GET: api/LivroAutors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivroAutor>>> GetLivroAutors()
        {
            return await _context.LivroAutors.ToListAsync();
        }

        // GET: api/LivroAutors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LivroAutor>> GetLivroAutor(int id)
        {
            var livroAutor = await _context.LivroAutors.FindAsync(id);

            if (livroAutor == null)
            {
                return NotFound();
            }

            return livroAutor;
        }

        // PUT: api/LivroAutors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivroAutor(int id, LivroAutor livroAutor)
        {
            if (id != livroAutor.Id)
            {
                return BadRequest();
            }

            _context.Entry(livroAutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroAutorExists(id))
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

        // POST: api/LivroAutors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LivroAutor>> PostLivroAutor(LivroAutor livroAutor)
        {
            _context.LivroAutors.Add(livroAutor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLivroAutor", new { id = livroAutor.Id }, livroAutor);
        }

        // DELETE: api/LivroAutors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivroAutor(int id)
        {
            var livroAutor = await _context.LivroAutors.FindAsync(id);
            if (livroAutor == null)
            {
                return NotFound();
            }

            _context.LivroAutors.Remove(livroAutor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LivroAutorExists(int id)
        {
            return _context.LivroAutors.Any(e => e.Id == id);
        }
    }
}
