namespace lee_hankins_backend_capstone.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<lee_hankins_backend_capstone.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(lee_hankins_backend_capstone.Models.ApplicationDbContext context)
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
            context.ProductionCharges.AddRange(new[] {

                new ProductionCharges  { Quantity = 1, ColorNumber = 1, NumberPrice = 1.50M, SetUpCharges = 35.00M },
                new ProductionCharges  { Quantity = 2, ColorNumber = 2, NumberPrice = 1.90M, SetUpCharges = 35.00M },
                new ProductionCharges  { Quantity = 3, ColorNumber = 3, NumberPrice = 2.30M, SetUpCharges = 35.00M },
                new ProductionCharges  { Quantity = 4, ColorNumber = 4, NumberPrice = 2.70M, SetUpCharges = 35.00M },
                new ProductionCharges  { Quantity = 5, ColorNumber = 5, NumberPrice = 3.10M, SetUpCharges = 35.00M },
                new ProductionCharges  { Quantity = 6, ColorNumber = 6, NumberPrice = 3.50M, SetUpCharges = 35.00M }
            }
            );
        }
    }
}
