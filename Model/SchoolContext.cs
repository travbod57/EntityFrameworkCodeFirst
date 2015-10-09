using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Model
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {

        }

        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
