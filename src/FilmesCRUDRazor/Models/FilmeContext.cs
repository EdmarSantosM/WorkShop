//Declarando as  bibliotecas  que  serão utilizadas

using Microsoft.EntityFrameworkCore;

namespace FilmesCRUDRazor.Models
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options)
        : base(options)

        {
            //Default
            //  Gera  a estrutura  da tabela de acordo com  propriedade  da classe Filme
        }
        public DbSet<Filme> Filme {get; set;}
    }
}
