


using CourseDomain;

namespace CourseServices
{
    public interface ICourseService
    {
        List<Course> GetCourses();
        Course GetCourse(int id);
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}