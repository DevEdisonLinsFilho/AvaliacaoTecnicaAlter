using Db.Entitites;
using Microsoft.EntityFrameworkCore;

namespace Db.Context
{
    /// <summary>
    /// Classe de configuração do EntityFramework para todas as tabelas pertinentes ao projeto
    /// </summary>
    public class AvaliacaoTecnicaContext : DbContext
    {
        public AvaliacaoTecnicaContext(DbContextOptions<AvaliacaoTecnicaContext> options) : base(options)
        {}
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(c => c.Category).HasForeignKey(c => c.CategoryId).IsRequired();            
        }
    }
}
