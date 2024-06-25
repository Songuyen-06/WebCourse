using System;
using System.Collections.Generic;

namespace CourseDomain.Models
{
    public partial class UserCourse
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public bool IsInCart { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
