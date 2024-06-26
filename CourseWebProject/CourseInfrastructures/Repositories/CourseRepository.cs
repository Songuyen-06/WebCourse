
using CourseDomain;
using CourseInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfrastructure
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(CoursesDbContext dbContext) : base(dbContext)
        {

        }

        public List<Course> GetContentCourseById(int courseId)
        {
            throw new NotImplementedException();

        }

        public List<Course> GetCourseByIdIncludeRating(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
