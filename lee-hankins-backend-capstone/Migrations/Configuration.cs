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
            //This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

            context.Customers.AddRange(new[] {
                new Customer { FirstName = "Andrew Peters",DateActive = DateTime.Now },
                new Customer { FirstName = "Brice Lambson", DateActive = DateTime.Now },
                new Customer { FirstName = "Rowan Miller", DateActive = DateTime.Now }
              }
            );


            context.Products.AddRange(new[]
            {
                  new Product { styleName = "shirt" }
            }
            );


          

        }
    }
}
