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
    public class QuestoesController : ControllerBase
    {
        private readonly SgpDbContext _context;

        public QuestoesController(SgpDbContext context)
        {
            _context = context;

            //if (_context.QuestoesItens.Count() == 0)
            //{
            //    _context.QuestoesItens.Add(new Questao { Nome = "Teste" });
            //    _context.SaveChanges();
            //}
        }
        // GET: api/Questoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Questao>>> GetQuestoesItens()
        {
            return await _context.Questao.ToListAsync();
        }
        // GET: api/Questoes
        [HttpGet("{id}")]
        public async Task<ActionResult<Questao>> GetQuestao(int id)
        {
            var questoesItem = await _context.Questao.FindAsync(id);

            if (questoesItem == null)
            {
                return NotFound();
            }

            return questoesItem;
        }
        // POST: api/Questoes
        [HttpPost]
        public async Task<ActionResult<Questao>> PostQuestao(Questao item)
        {
            _context.Questao.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuestao), new { id = item.Id }, item);
        }
        // PUT: api/Questoes
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestao(int id, Questao item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/Questoes
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestao(int id)
        {
            var questoesItem = await _context.Questao.FindAsync(id);

            if (questoesItem == null)
            {
                return NotFound();
            }

            _context.Questao.Remove(questoesItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}