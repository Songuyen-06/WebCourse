


using CourseDomain;

namespace CourseDomain
{
    public interface IReviewRepository : IGenericRepository<Review>
    {
        public IEnumerable<Review> GetListReviewByCourseId(int courseId);
    }
}
