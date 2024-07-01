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
        

    }
}
