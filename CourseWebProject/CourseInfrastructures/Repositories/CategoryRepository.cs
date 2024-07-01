using AutoMapper;
using CourseDomain;
using CourseDomain.Contracts;
using CourseInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CourseInfrastructure
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Category>> GetListCategory()
        {
            return await _entitySet.Include(c => c.Courses).ThenInclude(c => c.Instructor).
              Include(c => c.Courses).ThenInclude(c => c.StudentCourses).ThenInclude(sc => sc.User).
                 Include(c => c.Courses).ThenInclude(c => c.Sections).ThenInclude(s => s.Lectures).
                  Include(c => c.Courses).ThenInclude(c => c.Reviews).ThenInclude(r => r.Student).ToListAsync();
        }

    }
}
