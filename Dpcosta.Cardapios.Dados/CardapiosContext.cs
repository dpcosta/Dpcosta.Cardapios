using Dpcosta.Cardapios.Core;
using Microsoft.EntityFrameworkCore;

namespace Dpcosta.Cardapios.Dados
{
    public class CardapiosContext: DbContext
    {
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CardapioDB;Trusted_Connection=true;");
            }
        }
    }
}
