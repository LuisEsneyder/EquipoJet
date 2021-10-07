using Microsoft.EntityFrameworkCore;
using FinanzasMiHogar.App.Dominio;
namespace FinanzasMiHogar.App.Persistencia
{
    public class MyAppContext : DbContext
    {
        public DbSet<Usuarios> usuario {get; private set;}
        public DbSet<Gastos> gasto {get; private set;}
    
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