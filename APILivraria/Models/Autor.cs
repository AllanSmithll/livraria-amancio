using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILivraria.Models      
{
    public class Autor
    {
        public Autor(int idAutor, string nome, int dataNascimento)
        {
            IdAutor = idAutor;
            Nome = nome;
            this.DataNascimento = dataNascimento;
        }

        public int IdAutor { get; set; }

        public string Nome { get; set; }

        public int DataNascimento { get; set;}
    }
}