


using CourseDomain;
using CourseDomain.DTOs;

namespace CourseServices
{
    public interface ICourseService
    {
        Task<List<CourseDTO>> GetListCourse();
        Task<CourseDTO> GetCourseById(int id);
        Task AddCourse(Course course);
        Task UpdateCourse(Course course);
        Task DeleteCourse(Course course);
    }
}