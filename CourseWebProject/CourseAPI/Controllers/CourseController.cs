using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseDomain;
using CourseServices;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }




        // GET: api/Course
        [HttpGet("getCourseById")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            var courses = _courseService.GetCourseById(id);

           
            return Ok(courses);

        }
        [HttpGet("getCourses")]
        public async Task<IActionResult> GetListCourse()
        {
            var courses = _courseService.GetListCourse();


            return Ok(courses);
        }


    }
}
