namespace ThotMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ThotMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            //Para produccion quitar
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ThotMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
