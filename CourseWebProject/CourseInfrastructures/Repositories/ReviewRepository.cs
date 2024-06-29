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

        public IEnumerable<Review> GetListReviewByCourseId(int courseId)
        {
            return _entitySet.Where(r => r.CourseId == courseId).Include(r => r.Student).AsEnumerable();

        }

    }
}
