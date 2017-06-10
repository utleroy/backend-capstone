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

            context.Customer.AddRange(new[] {
                new Customer { FirstName = "Lee", LastName = "Hankins", Email = "bryanlhankins@gmail.com", DateActive = DateTime.Now },
                new Customer { FirstName = "John", LastName = "Brown", Email = "blah@blah.com", DateActive = DateTime.Now },
                new Customer { FirstName = "Mary", LastName = "Black", Email = "whah@whah.com", DateActive = DateTime.Now }
                }
            );


            context.Product.AddRange(new[]
            {
                  new Product { styleName = "shirt" }
                }
            );

            


          

        }
    }
}
