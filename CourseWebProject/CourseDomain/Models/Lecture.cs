using System;
using System.Collections.Generic;

namespace CourseDomain.Models
{
    public partial class Lecture
    {
        public int LectureId { get; set; }
        public int? SectionId { get; set; }
        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        public string? VideoUrl { get; set; }
        public string? Duration { get; set; }
        public int? Position { get; set; }

        public virtual Section? Section { get; set; }
    }
}
