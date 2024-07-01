


using CourseDomain.DTOs;

namespace CourseDomain
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<IEnumerable<Course>> GetListCourseByCategoryId(int cateId);

        public IQueryable<Course> GetListCourseByInclude();

        public Task<Course> GetCourseById(int courseId);
        public  Task<IEnumerable<Course>> GetListCourseByStudentId(int stdId, bool isInCart);

    }
}
