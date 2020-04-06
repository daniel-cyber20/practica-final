namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<proyecto.Models.productoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;  
        }

        protected override void Seed(proyecto.Models.productoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
