using CourseDomain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseInfrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly CoursesDbContext _dbContext;
        protected readonly DbSet<T> _entitySet;

        public GenericRepository(CoursesDbContext dbContext)
        {
            _dbContext = dbContext;
            _entitySet = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            _dbContext.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _entitySet.FirstOrDefault(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _entitySet.AsEnumerable();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _entitySet.Where(expression).AsEnumerable();
        }

        public void Remove(T entity)
        {
            _dbContext.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);
        }
    }
}
