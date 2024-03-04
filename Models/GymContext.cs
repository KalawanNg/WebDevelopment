using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace IdentityPractice.Models
{
    public class GymContext : IdentityDbContext<IdentityUser>
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options)
        {
        }

        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Building> Buildings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Membership>()
            .HasOne(m => m.IdentityUser)
            .WithOne()
            .HasForeignKey<Membership>(m => m.IdentityUserId);
        }
    }
}
