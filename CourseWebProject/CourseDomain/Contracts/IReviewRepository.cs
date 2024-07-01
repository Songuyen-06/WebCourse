


using CourseDomain;

namespace CourseDomain
{
    public interface IReviewRepository : IGenericRepository<Review>
    {
        public Task<IEnumerable<Review>> GetListReviewByCourseId(int courseId);
        public IQueryable<Review> GetListReviewByInclude();

    }
}
