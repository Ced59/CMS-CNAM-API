using Entities.CommentairesEntities;
using Entities.ExemplesEntitie;
using Microsoft.EntityFrameworkCore;

namespace Entities.DatabasesContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Exemple> Exemples { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }

        public DatabaseContext() : base() {}
        
        public DatabaseContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exemple>().ToTable("Exemples");
            modelBuilder.Entity<Commentaire>().ToTable("Commentaires");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CMS_CNAM_Db;Trusted_Connection=True;MultipleActiveResultSets=true", builder =>
                {
                    builder.CommandTimeout(300);
                });
            }

            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
