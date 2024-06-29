using CourseDomain;
using CourseDomain.Contracts;
using CourseInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfrastructure
{
    public class SectionRepository : GenericRepository<Section>, ISectionRepository
    {
        public SectionRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Section> GetSectionsByCourseId(int courdId)
        {
            _entitySet.Include(s => s.Lectures).
                Include(s => s.Documents);
            Expression<Func<Section, bool>> filter = s => s.CourseId == courdId;
            return GetAll(filter);
        }
    }
}
