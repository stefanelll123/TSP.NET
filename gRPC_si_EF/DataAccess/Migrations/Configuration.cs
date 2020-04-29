using System.Data.Entity.Migrations;

namespace DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ModelSelfReference>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ModelSelfReference context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
