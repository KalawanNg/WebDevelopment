using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityPractice.Models
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string Address { get; set; }
        public string TeleNumber {get; set;}
    }
}
