using Entities.ExemplesEntitie;
using Microsoft.EntityFrameworkCore;

namespace Entities.DatabasesContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Exemple> Exmples { get; set; }

        public DatabaseContext() : base() {}
        
        public DatabaseContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exemple>().ToTable("Exemples");
        }
    }
}
