﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CesdeUniversidad.Models
{
    public enum Grade
    {
        A, B, C, D, E
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set;}

        public virtual Course Course { get; set; }

        public virtual Estudiante Student { get; set; }

    }
}