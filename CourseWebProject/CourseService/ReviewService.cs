using CourseDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork UnitOfWork;
        public ReviewService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }


        public IEnumerable<Review> GetListReviewByCourseId(int courseId)
        {
            return UnitOfWork.IReviewRepository.GetListReviewByCourseId(courseId);
        }
    }
}
