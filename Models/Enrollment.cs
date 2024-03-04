using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IdentityPractice.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int MembershipId { get; set; }
        public int CourseId { get; set; }

        [JsonIgnore]
        public Membership Membership { get; set; }
        public Course Course { get; set; }
    }
}