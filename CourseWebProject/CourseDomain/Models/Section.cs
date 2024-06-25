using System;
using System.Collections.Generic;

namespace CourseDomain.Models
{
    public partial class Section
    {
        public Section()
        {
            Lectures = new HashSet<Lecture>();
        }

        public int SectionId { get; set; }
        public int? CourseId { get; set; }
        public string Title { get; set; } = null!;
        public string? Duration { get; set; }
        public int? Position { get; set; }

        public virtual Course? Course { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
    }
}
