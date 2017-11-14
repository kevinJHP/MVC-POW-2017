namespace _20171112.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_20171112.Models._20171112Context>
    {
        public Configuration()
        {
            //Activar las migraciones automáticas
            AutomaticMigrationDataLossAllowed = true;
            //----------
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_20171112.Models._20171112Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
