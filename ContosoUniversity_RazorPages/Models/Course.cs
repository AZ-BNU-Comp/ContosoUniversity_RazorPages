﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_RazorPages.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        // Relationship or Navigation Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
