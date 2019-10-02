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
    public class OpcaoController : ControllerBase
    {
        private readonly SgpDbContext _context;

        public OpcaoController(SgpDbContext context)
        {
            _context = context;

        }
        // GET: api/Opcao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OpcaoAvaliacao>>> GetOpcaoItens()
        {
            return await _context.OpcaoAvaliacao.ToListAsync();
        }
        // GET: api/Opcao
        [HttpGet("{id}")]
        public async Task<ActionResult<OpcaoAvaliacao>> GetOpcaoAvaliacao(int id)
        {
            var opcaoItem = await _context.OpcaoAvaliacao.FindAsync(id);

            if (opcaoItem == null)
            {
                return NotFound();
            }

            return opcaoItem;
        }
        // POST: api/Opcao
        [HttpPost]
        public async Task<ActionResult<OpcaoAvaliacao>> PostOpcaoAvaliacao(OpcaoAvaliacao item)
        {
            _context.OpcaoAvaliacao.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOpcaoAvaliacao), new { id = item.Id }, item);
        }
        // PUT: api/Opcao
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpcaoAvaliacao(int id, OpcaoAvaliacao item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/Opcao
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpcaoAvaliacao(int id)
        {
            var opcaoItem = await _context.OpcaoAvaliacao.FindAsync(id);

            if (opcaoItem == null)
            {
                return NotFound();
            }

            _context.OpcaoAvaliacao.Remove(opcaoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}