using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityPractice.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}