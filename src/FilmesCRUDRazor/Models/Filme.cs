using System;

// Criando a classe  com  seus  atributos

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeiD { get; set; }

        public string Titulo { get; set; }

        public DateTime DataLancamento { get; set; }

        public string Genero { get; set; }

        public decimal Preço { get; set; }
    }
}
