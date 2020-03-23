using Lab004.EF.Entities;
using System.Data.Entity;

namespace Lab004.EF
{
    public class ModelSelfReference : DbContext
    {
        public ModelSelfReference()
            : base("name=ModelSelfReference")
        {
        }

        public DbSet<SelfReference> SelfReferences { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Photograph> Photographs { get; set; }

        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        public DbSet<Business> Businesses { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);

            modelBuilder.Entity<Product>()
                .Map(m =>
                {
                    m.Properties(p => new { p.SKU, p.Description, p.Price });
                    m.ToTable("Product", "BazaDeDate");
                })
                .Map(m =>
                {
                    m.Properties(p => new { p.SKU, p.ImageURL });
                    m.ToTable("ProductWebInfo", "BazaDeDate");
                });

            modelBuilder.Entity<Photograph>()
                .HasRequired(p => p.PhotographFullImage)
                .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
                .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
                .ToTable("Photograph", "BazaDeDate");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .Map<FullTimeEmployee>(m => m.Requires("EmployeeType")
                    .HasValue(1))
                .Map<HourlyEmployee>(m => m.Requires("EmployeeType")
                    .HasValue(2));
        }
    }
}