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
    public class DisciplinaController : ControllerBase
    {
        private readonly SgpDbContext _context;

        public DisciplinaController(SgpDbContext context)
        {
            _context = context;

            //if (_context.DisciplinaItens.Count() == 0)
            //{
            //    _context.DisciplinaItens.Add(new Disciplina { Nome = "Teste" });
            //    _context.SaveChanges();
            //}
        }
        // GET: api/Disciplina
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disciplina>>> GetDisciplinaItens()
        {
            return await _context.Disciplina.ToListAsync();
        }
        // GET: api/Disciplina
        [HttpGet("{id}")]
        public async Task<ActionResult<Disciplina>> GetDisciplina(int id)
        {
            var disciplinaItem = await _context.Disciplina.FindAsync(id);

            if (disciplinaItem == null)
            {
                return NotFound();
            }

            return disciplinaItem;
        }
        // POST: api/Disciplina
        [HttpPost]
        public async Task<ActionResult<Disciplina>> PostDisciplina(Disciplina item)
        {
            _context.Disciplina.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDisciplina), new { id = item.Id }, item);
        }
        // PUT: api/Disciplina
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDisciplina(int id, Disciplina item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/Disciplina
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDisciplina(int id)
        {
            var disciplinaItem = await _context.Disciplina.FindAsync(id);

            if (disciplinaItem == null)
            {
                return NotFound();
            }

            _context.Disciplina.Remove(disciplinaItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}