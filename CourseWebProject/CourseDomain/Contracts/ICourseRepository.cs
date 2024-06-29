


using CourseDomain.DTOs;

namespace CourseDomain
{
    public interface ICourseRepository : IGenericRepository<Course>
    {

        public Course GetCourseById(int courseId);
    }
}
