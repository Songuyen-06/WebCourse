
using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using CourseInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfrastructure
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(CoursesDbContext dbContext) : base(dbContext)
        {

        }
        public IQueryable<Course> GetListCourseByInclude()
        {
            return _entitySet.Include(c => c.Instructor).
                Include(c => c.Category).
                Include(c => c.Sections).ThenInclude(s => s.Lectures).
                  Include(c => c.Reviews).ThenInclude(r => r.Student).
                     Include(c => c.StudentCourses).ThenInclude(sc => sc.User)
                     .ThenInclude(u => u.Role);
            ;
        }
        public async Task<IEnumerable<Course>> GetListCourseByCategoryId(int cateId)
        {
            return await GetListCourseByInclude().Where(c=>c.CategoryId==cateId).ToListAsync();

        }
        public async Task<Course> GetCourseById(int courseId)
        {
            return await GetListCourseByInclude().FirstOrDefaultAsync(c => c.CourseId == courseId);

        }

        public async Task<IEnumerable<Course>> GetListCourseByStudentId(int stdId, bool isInCart)
        {
            return await GetListCourseByInclude().
                Where(c => c.StudentCourses.
                Any(sc => sc.UserId == stdId && sc.User.Role.RoleId == 1 && sc.IsInCart== isInCart))
                .ToListAsync();

        }






    }
}
