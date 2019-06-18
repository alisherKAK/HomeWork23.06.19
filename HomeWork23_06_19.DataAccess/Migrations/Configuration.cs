namespace HomeWork23_06_19.DataAccess.Migrations
{
    using HomeWork23_06_19.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeWork23_06_19.DataAccess.TasksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeWork23_06_19.DataAccess.TasksContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Periods.AddRange(new Period[]
            {
                new Period(){Id = 1, PeriodTime = "Once"},
                new Period(){Id = 2, PeriodTime = "Every day"},
                new Period(){Id = 3, PeriodTime = "Every month"},
                new Period(){Id = 4, PeriodTime = "Every year"},
            });
            context.SaveChanges();
        }
    }
}
