

namespace APILivraria.Models
{
    public class Livro
    {
        public Livro(string isbn, string titulo, string subtitulo, string resumo, string genero, int quantPaginas, DateOnly publicacao, int edicao, string nomeEditora, string nomeAutor)
        {
            Isbn = isbn;
            Titulo = titulo;
            Subtitulo = subtitulo;
            Resumo = resumo;
            Genero = genero;
            QuantPaginas = quantPaginas;
            Publicacao = publicacao;
            Edicao = edicao;
            this.nomeEditora = nomeEditora;
            this.nomeAutor = nomeAutor;
        }

        public string Isbn { get; set; }

        public string Titulo { get; set;}

        public string  Subtitulo { get; set; }

        public string Resumo { get; set; }

        public string Genero { get; set; }

        public int QuantPaginas { get; set; }

        public DateOnly Publicacao { get; set; }

        public int Edicao { get; set; }

        public string nomeEditora { get; set; }

        public string nomeAutor { get; set; }
    }
}