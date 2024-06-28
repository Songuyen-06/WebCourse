
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
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(CoursesDbContext dbContext) : base(dbContext)
        {

        }

        public Course  GetContentCourseById(int courseId)
        {
            Expression<Func<Course, bool>> filter = c => c.CourseId == courseId;
            return Get(filter);

        }

        public List<Course> GetCourseByIdIncludeRating(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
