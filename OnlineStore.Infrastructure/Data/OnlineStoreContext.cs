using Microsoft.EntityFrameworkCore;
using OnlineStore.Infrastructure.Data.Entities;

namespace OnlineStore.Infrastructure.Data
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } // Represents the "Products" table

        //Add other DbSets for other tables

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships, constraints, and indexes here (if needed)
            // Example:
            // modelBuilder.Entity<Product>()
            //     .HasOne(p => p.Category)
            //     .WithMany(c => c.Products)
            //     .HasForeignKey(p => p.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}