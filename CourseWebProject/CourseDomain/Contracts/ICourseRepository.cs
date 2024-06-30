


using CourseDomain.DTOs;

namespace CourseDomain
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        public IQueryable<Course> GetListCourseByInclude();

        public Task<Course> GetCourseById(int courseId);
    }
}
