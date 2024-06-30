using CourseServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        public ISectionService _sectionService { get; set; }

        [HttpGet("getListSectionByCourseId/{courseId}")]
        public async Task<IActionResult> GetListSectionByCourseId(int courseId)
        {

            var sections =await _sectionService.GetListSectionByCourseId(courseId);
            return Ok(sections);
        }
    }
}
