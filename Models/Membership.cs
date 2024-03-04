using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityPractice.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string Name { get; set; }
        public string IdentityUserId {get; set;}
        public IdentityUser IdentityUser { get; set; }
        [JsonIgnore]
        public List<Enrollment>? Enrollments { get; set; }
    }
}
