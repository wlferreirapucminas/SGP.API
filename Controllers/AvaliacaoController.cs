using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SgpApi.Models;

namespace SgpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        private readonly SgpDbContext _context;

        public AvaliacaoController(SgpDbContext context)
        {
            _context = context;

        }
        // GET: api/Avaliacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avaliacao>>> GetAvaliacaoItens()
        {
            return await _context.Avaliacao.ToListAsync();
        }
        // GET: api/Avaliacao
        [HttpGet("{id}")]
        public async Task<ActionResult<Avaliacao>> GetAvaliacao(int id)
        {
            var avaliacaoItem = await _context.Avaliacao.FindAsync(id);

            if (avaliacaoItem == null)
            {
                return NotFound();
            }

            return avaliacaoItem;
        }
        // POST: api/Avaliacao
        [HttpPost]
        public async Task<ActionResult<Avaliacao>> PostAvaliacao(Avaliacao item)
        {
            _context.Avaliacao.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAvaliacao), new { id = item.Id }, item);
        }
        // PUT: api/Avaliacao
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAvaliacao(int id, Avaliacao item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/Avaliacao
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAvaliacao(int id)
        {
            var avaliacaoItem = await _context.Avaliacao.FindAsync(id);

            if (avaliacaoItem == null)
            {
                return NotFound();
            }

            _context.Avaliacao.Remove(avaliacaoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}