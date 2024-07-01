


using CourseDomain;
using CourseDomain.DTOs;

namespace CourseServices
{
    public interface ICourseService
    {
        Task<List<CourseDTO>> GetListCourseByCategoryId(int cateId);

        Task<List<CourseDTO>> GetListCourse();
        Task<CourseDTO> GetCourseById(int id);
        Task<List<CourseDTO>> GetListCourseByStudentId(int stdId, bool isInCart);

        Task AddCourse(Course course);
        Task UpdateCourse(Course course);
        Task DeleteCourse(Course course);
    }
}