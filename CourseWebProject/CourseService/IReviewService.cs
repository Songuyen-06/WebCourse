using CourseDomain;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public  interface IReviewService
    {
        public Task<List<ReviewDTO>> GetListReviewByCourseId(int courseId);
        public  Task<List<ReviewDTO>> GetListReview();

    }
}
