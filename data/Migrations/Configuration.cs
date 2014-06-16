namespace data.Migrations
{
    using FamilyDirectory.web;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(data.ApplicationDbContext context)
        {
           Seeder.Seed(context);
        }
    }
}
