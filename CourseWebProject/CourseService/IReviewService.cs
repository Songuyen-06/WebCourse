using CourseDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public  interface IReviewService
    {
        public IEnumerable<Review> GetListReviewByCourseId(int courseId);
    }
}
