﻿using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("getCourses")]
        public async Task<IActionResult> GetCourses()
        {
            var courses = _courseService.GetCourses().ToList();

           
            return Ok(courses);
        }


        //// GET: api/Course/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Course>> GetCourse(int id)
        //{
        //  if (_context.Courses == null)
        //  {
        //      return NotFound();
        //  }
        //    var course = await _context.Courses.FindAsync(id);

        //    if (course == null)
        //    {
        //        return NotFound();
        //    }

        //    return course;
        //}

        //// PUT: api/Course/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCourse(int id, Course course)
        //{
        //    if (id != course.CourseId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(course).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CourseExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Course
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Course>> PostCourse(Course course)
        //{
        //  if (_context.Courses == null)
        //  {
        //      return Problem("Entity set 'CoursesDbContext.Courses'  is null.");
        //  }
        //    _context.Courses.Add(course);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCourse", new { id = course.CourseId }, course);
        //}

        //// DELETE: api/Course/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCourse(int id)
        //{
        //    if (_context.Courses == null)
        //    {
        //        return NotFound();
        //    }
        //    var course = await _context.Courses.FindAsync(id);
        //    if (course == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Courses.Remove(course);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CourseExists(int id)
        //{
        //    return (_context.Courses?.Any(e => e.CourseId == id)).GetValueOrDefault();
        //}
    }
}
