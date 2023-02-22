using APILivraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace APILivraria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly Contexto _contexto;

        public LivroController(Contexto contexto) 
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> PegarTodosAsync() => await _contexto.Livros.ToListAsync();

        [HttpGet("{Isbn}")]
        public async Task<ActionResult<Livro>> PegarLivroPeloId(int Isbn) {
            Livro livro = await _contexto.Livros.FindAsync(Isbn);

            if(livro == null)
                return NotFound();

            return livro;
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> SalvarPessoaAsync(Livro livro) {
            await _contexto.Livros.AddAsync(livro);
            await _contexto.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarPessoaAsync(Livro livro) {
            _contexto.Livros.Update(livro);
            await _contexto.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{Isbn}")]
        public async Task<ActionResult> ExcluirPessoaAsync(int Isbn) {
            Livro livro = await _contexto.Livros.FindAsync(Isbn);
            if (livro != null)
                _contexto.Remove(Isbn);
                await _contexto.SaveChangesAsync();
                return Ok();
        }
    }
}