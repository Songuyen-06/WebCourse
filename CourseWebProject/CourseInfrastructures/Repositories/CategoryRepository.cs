using CourseDomain;
using CourseDomain.Contracts;
using CourseInfrastructure.Repositories;

namespace CourseInfrastructure
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
