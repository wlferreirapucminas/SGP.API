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
    public class MateriaController : ControllerBase
    {
        private readonly SgpDbContext _context;

        public MateriaController(SgpDbContext context)
        {
            _context = context;

            //if (_context.MateriaItens.Count() == 0)
            //{
            //    _context.MateriaItens.Add(new Materia { Nome = "Teste" });
            //    _context.SaveChanges();
            //}
        }
        // GET: api/Materia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMateriaItens()
        {
            return await _context.Materia.ToListAsync();
        }
        // GET: api/Materia
        [HttpGet("{id}")]
        public async Task<ActionResult<Materia>> GetMateria(int id)
        {
            var materiaItem = await _context.Materia.FindAsync(id);

            if (materiaItem == null)
            {
                return NotFound();
            }

            return materiaItem;
        }
        // POST: api/Materia
        [HttpPost]
        public async Task<ActionResult<Materia>> PostMateria(Materia item)
        {
            _context.Materia.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMateria), new { id = item.Id }, item);
        }
        // PUT: api/Materia
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateria(int id, Materia item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/Materia
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateria(int id)
        {
            var materiaItem = await _context.Materia.FindAsync(id);

            if (materiaItem == null)
            {
                return NotFound();
            }

            _context.Materia.Remove(materiaItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}