using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseDomain;
using CourseServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.OData.Query;

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

        [HttpGet("getListCourseByStudentId/{stdId}/{isInCart}")]
        public async Task<IActionResult> GetListCourseByStudentId(int stdId, bool isInCart)
        {
            var courses = await _courseService.GetListCourseByStudentId(stdId, isInCart);
            return Ok(courses);
        }



        // GET: api/Course
        [HttpGet("getCourseById/{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            var courses =await _courseService.GetCourseById(id);

           
            return Ok(courses);

        }
        [HttpGet("getListCourse")]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            var courses = await _courseService.GetListCourse();


            return  Ok(courses);
        }
        [HttpGet("getListCourseByCategoryId/{cateId}")]
        public async Task<IActionResult> GetListCourseByCategoryId(int cateId)
        {
            var courses = await _courseService.GetListCourseByCategoryId(cateId);


            return Ok(courses);
        }

    }
}
