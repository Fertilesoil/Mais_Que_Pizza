using MaisQuePizza.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class PizzariaDbContext : DbContext
    {
        public PizzariaDbContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Pizzas>().ToTable("tb_pizzas");
            modelbuilder.Entity<Categoria>().ToTable("tb_categoria");

            _ = modelbuilder.Entity<Pizzas>() 
                .HasOne(_ => _.Categoria) 
                .WithMany(c => c.Pizzas) 
                .HasForeignKey("CategoriaId")
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Pizzas> Pizzas  { get; set; } = null!;
        public DbSet<Categoria> Categoria { get; set; } = null!;
    }
}