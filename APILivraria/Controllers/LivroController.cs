using APILivraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APILivraria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public async Task<ActionResult<Livro>> PegarLivroPeloId(string Isbn) {
            Livro livro = await _contexto.Livros.FindAsync(Isbn);

            if(livro == null)
                return NotFound();

            return livro
        }
    }
}