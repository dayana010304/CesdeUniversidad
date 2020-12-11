using CesdeUniversidad.Models;
using System;
using System.Collections.Generic;

namespace CesdeUniversidad.DAL
{
    public class Schoollnitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var estudiantes = new List<Estudiante>
            {
                new Estudiante{ FirstMidName="Carson",LatsName="Alexander", EnrollmentDate=DateTime.Parse("2005-09-01") },
                new Estudiante{ FirstMidName="Andres",LatsName="Bustamante", EnrollmentDate=DateTime.Parse("2002-09-01") },
                new Estudiante{ FirstMidName="Luis",LatsName="Cardona", EnrollmentDate=DateTime.Parse("2003-09-01") },
                new Estudiante{ FirstMidName="Ana",LatsName="Trejos", EnrollmentDate=DateTime.Parse("2002-09-01") },
                new Estudiante{ FirstMidName="Daniela",LatsName="Arias", EnrollmentDate=DateTime.Parse("2001-09-01") },
                new Estudiante{ FirstMidName="Manuela",LatsName="Zapata", EnrollmentDate=DateTime.Parse("2003-09-01") },
            };

            estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1050, Title="Español", Credits=3,},
                new Course{CourseID=4022, Title="Ingles", Credits=3,},
                new Course{CourseID=4021, Title="Matematicas", Credits=3,},
                new Course{CourseID=1045, Title="Español", Credits=3,},
                new Course{CourseID=3141, Title="Español", Credits=3,},
                new Course{CourseID=2021, Title="Español", Credits=3,},
                new Course{CourseID=2042, Title="Economia", Credits=3,},
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.E},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.E},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.E},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }
    }
}