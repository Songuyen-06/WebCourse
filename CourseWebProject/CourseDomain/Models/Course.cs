using System;
using System.Collections.Generic;

namespace CourseDomain.Models
{
    public partial class Course
    {
        public Course()
        {
            Checkouts = new HashSet<Checkout>();
            Enrollments = new HashSet<Enrollment>();
            Reviews = new HashSet<Review>();
            Sections = new HashSet<Section>();
            UserCourses = new HashSet<UserCourse>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; } = null!;
        public int? InstructorId { get; set; }
        public string? Description { get; set; }
        public string? Level { get; set; }
        public string? Duration { get; set; }
        public decimal? Price { get; set; }
        public decimal? Rating { get; set; }
        public int? CategoryId { get; set; }
        public string? Url { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Checkout> Checkouts { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
