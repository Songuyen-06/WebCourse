using CourseDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    internal interface IReviewService
    {
        public IEnumerable<Review> GetListReviewByCourseId(int courseId);
    }
}
