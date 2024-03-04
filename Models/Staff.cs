using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityPractice.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string EmailAddress {get; set;}
        [JsonIgnore]
        public List<Enrollment>? Enrollments { get; set; }
    }
}

