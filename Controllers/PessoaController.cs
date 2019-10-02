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
    public class PessoaController : ControllerBase
    {
        private readonly SgpDbContext _context;

        public PessoaController(SgpDbContext context)
        {
            _context = context;
        }
        // GET: api/Pessoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoaItens()
        {
            return await _context.Pessoa.ToListAsync();
        }
        // GET: api/Pessoa
        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            var pessoaItem = await _context.Pessoa.FindAsync(id);

            if (pessoaItem == null)
            {
                return NotFound();
            }

            return pessoaItem;
        }
        // POST: api/Pessoa
        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa item)
        {
            _context.Pessoa.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPessoa), new { id = item.Id }, item);
        }
        // PUT: api/Pessoa
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoa(int id, Pessoa item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/Pessoa
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoa(int id)
        {
            var pessoaItem = await _context.Pessoa.FindAsync(id);

            if (pessoaItem == null)
            {
                return NotFound();
            }

            _context.Pessoa.Remove(pessoaItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}