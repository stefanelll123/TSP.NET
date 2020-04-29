using System.Data.Entity;
using DataAccess.Entities;

namespace DataAccess
{
    public class ModelSelfReference : DbContext
    {
        public ModelSelfReference()
            : base("name=ModelSelfReference")
        {
        }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>()
                .HasMany(m => m.Comments)
                .WithRequired(m => m.Post);


            //modelBuilder.Entity<Comment>()
            //    .HasOptional(e => e.Post)
            //    .WithMany(c => c.Comments);

            base.OnModelCreating(modelBuilder);
        }
    }
}