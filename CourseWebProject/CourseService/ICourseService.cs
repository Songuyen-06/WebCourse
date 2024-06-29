


using CourseDomain;
using CourseDomain.DTOs;

namespace CourseServices
{
    public interface ICourseService
    {
        List<CourseDTO> GetListCourse();
        CourseDTO  GetCourseById(int id);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
    }
}