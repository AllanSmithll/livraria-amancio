using Microsoft.EntityFrameworkCore;

namespace APILivraria.Models
{
    [PrimaryKey(nameof(Isbn))]
    public class Livro
    {
        public Livro(string isbn, string titulo, string subtitulo, string resumo, string genero, int quantPaginas, string dataPublicacao, string nomeAutor, string nomeEditora)
        {
            Isbn = isbn;
            Titulo = titulo;
            Subtitulo = subtitulo;
            Resumo = resumo;
            Genero = genero;
            QuantPaginas = quantPaginas;
            DataPublicacao = dataPublicacao;
            NomeAutor = nomeAutor;
            NomeEditora = nomeEditora;
        }

        public string Isbn { get; set; }

        public string Titulo { get; set; }

        public string Subtitulo { get; set; }

        public string Resumo { get; set; }

        public string Genero { get; set; }

        public int QuantPaginas { get; set; }

        public string DataPublicacao{ get; set; }

        public string NomeAutor { get; set; }

        public string NomeEditora { get; set; }
    }
}