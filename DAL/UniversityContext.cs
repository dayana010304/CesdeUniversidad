using CesdeUniversidad.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CesdeUniversidad.DAL
{ 
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("UniversityContext")
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}