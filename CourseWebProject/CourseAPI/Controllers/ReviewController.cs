using CourseDomain;
using CourseServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        public readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet("getListReview")]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            return Ok(await _reviewService.GetListReview());
        }


        [HttpGet("getListReviewByCourseId/{courseId}")]
        public async Task<IActionResult> GetListReviewByCourseId( int courseId)
        {
            return Ok(await _reviewService.GetListReviewByCourseId(courseId));
        }
    }
}
