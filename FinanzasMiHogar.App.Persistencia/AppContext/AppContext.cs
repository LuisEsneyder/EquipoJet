using Microsoft.EntityFrameworkCore;
using FinanzasMiHogar.App.Dominio;
namespace FinanzasMiHogar.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Usuarios> usuario {get; set;}
        public DbSet<Gastos> Gasto {get; set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Finanzas");
            }
        }
    }
}