using Microsoft.EntityFrameworkCore;

namespace APILivraria.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Livro> Livros { get; set; } = null!;

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            
        }
    }
}