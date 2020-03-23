using EfCore2020.Entities;
using Microsoft.EntityFrameworkCore;

using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace EfCore2020
{
    public sealed class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NBKR003997\\SQLEXPRESS;Database=EFCore2020;Trusted_Connection = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>();

            modelBuilder.Entity<Order>()
                .HasOne(od => od.Customer)
                .WithMany(o => o.Orders);

            modelBuilder.Entity<Customer>()
                .HasMany(p => p.Orders)
                .WithOne(od => od.Customer);

            modelBuilder.Entity<Artist>()
                .HasMany(p => p.Albums);

            modelBuilder.Entity<Album>()
                .HasMany(p => p.Artists);
        }
    }
}
