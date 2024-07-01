using AutoMapper;
using CourseDomain;
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
    internal class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
        public IQueryable<Review> GetListReviewByInclude()
        {
            return _entitySet.Include(r => r.Course).Include(r => r.Student);
        }
        public async Task<IEnumerable<Review>> GetListReviewByCourseId(int courseId)
        {
            return await GetListReviewByInclude().Where(r => r.CourseId == courseId).ToListAsync();
        }

    }
}
