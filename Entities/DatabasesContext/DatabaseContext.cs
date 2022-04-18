using Entities.CommentairesEntities;
using Entities.DescriptionsEntitie;
using Entities.ExemplesEntitie;
using Entities.ImagesEntitie;
using Entities.ProduitsEntitie;
using Entities.StocksEntitie;
using Entities.TagsEntitie;
using Entities.VariantsEntitie;
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
            modelBuilder.Entity<Description>().ToTable("Descriptions");
            modelBuilder.Entity<Image>().ToTable("Images");
            modelBuilder.Entity<Produit>().ToTable("Produits");
            modelBuilder.Entity<Stock>().ToTable("Stocks");
            modelBuilder.Entity<Tag>().ToTable("Tags");
            modelBuilder.Entity<Variant>().ToTable("Variants");
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
