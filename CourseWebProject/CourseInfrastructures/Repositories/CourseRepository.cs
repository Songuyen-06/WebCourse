
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
                Include(c => c.StudentCourses).ThenInclude(sc => sc.User).
                Include(c => c.Sections).ThenInclude(s => s.Lectures).
                  Include(c => c.Reviews).ThenInclude(r => r.Student);
        }

        public async Task<Course> GetCourseById(int courseId)
        {
            return await GetListCourseByInclude().FirstOrDefaultAsync(c => c.CourseId == courseId);

        }








    }
}
