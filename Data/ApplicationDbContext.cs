using Microsoft.EntityFrameworkCore;
using SalesDb.Models;

namespace SalesDb.Data
{
    internal class ApplicationDbContext:DbContext
    {
        public DbSet<Customer>? Customers { set; get; }
        public DbSet<Product>? Products { set; get; }
        public DbSet<Sale>? Sales { set; get; }
        public DbSet<Store>? Stores { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFSalesDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Customer Table
            modelBuilder.Entity<Customer>()
                .HasKey(p => p.CustomerId);
            modelBuilder.Entity<Customer>()
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsUnicode(true);
            modelBuilder.Entity<Customer>()
                .Property(p => p.Email)
                .HasMaxLength(80)
                .IsUnicode(false);
            //Product Table
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);        
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(50)                 
                .IsUnicode(true);
            //Store Table
            modelBuilder.Entity<Store>()
                .HasKey(p => p.StoreId);
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(80)
                .IsUnicode(true);
            //Sale Table 
            modelBuilder.Entity<Sale>()
                .HasKey(p => p.SaleId);
        }
    }
}
