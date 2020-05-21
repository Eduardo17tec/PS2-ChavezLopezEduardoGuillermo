namespace PS2_ChavezLopezEduardoGuillermo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PS2_ChavezLopezEduardoGuillermo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PS2_ChavezLopezEduardoGuillermo.Models.ApplicationDbContext";
        }

        protected override void Seed(PS2_ChavezLopezEduardoGuillermo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
