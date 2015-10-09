namespace Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolContext context)
        {

            Teacher t1 = new Teacher { FirstName = "Miss", LastName = "Lanes" };
            context.Teachers.AddOrUpdate(t1);

            context.Pupils.AddOrUpdate(new Pupil { FirstName = "Andrew", LastName = "Peters", Teacher = t1, BirthDate = new DateTime(1996, 12, 12) },
                                       new Pupil { FirstName = "Sam", LastName = "Towers", Teacher = t1, BirthDate = new DateTime(1997, 02, 16) }
                                       );

            context.SaveChanges();
        }
    }
}
