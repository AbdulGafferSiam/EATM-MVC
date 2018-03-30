using E_ATMMVC.Models;

namespace E_ATMMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<E_ATMMVC.Models.EatmDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(E_ATMMVC.Models.EatmDbContext context)
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
            context.AccountModels.AddOrUpdate(p => p.CardNumber,
                new AccountModel() { CardNumber = 1, PinNumber = 123, Balance = 500 },
                new AccountModel() { CardNumber = 2, PinNumber = 234, Balance = 1000 },
                new AccountModel() { CardNumber = 3, PinNumber = 345, Balance = 800 });
        }
    }
}
