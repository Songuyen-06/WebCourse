using System;
using System.Collections.Generic;

namespace CourseDomain.Models
{
    public partial class User
    {
        public User()
        {
            Checkouts = new HashSet<Checkout>();
            Enrollments = new HashSet<Enrollment>();
            Reviews = new HashSet<Review>();
            UserCourses = new HashSet<UserCourse>();
        }

        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Password { get; set; } = null!;
        public string? Bio { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Checkout> Checkouts { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
