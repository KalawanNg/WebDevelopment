using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityPractice.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string Name { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}
