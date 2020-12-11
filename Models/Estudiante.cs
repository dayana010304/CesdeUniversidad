using System;
using System.Collections.Generic;

namespace CesdeUniversidad.Models
{
    public class Estudiante
    {
        public int ID { get; set; }

        public string LatsName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}