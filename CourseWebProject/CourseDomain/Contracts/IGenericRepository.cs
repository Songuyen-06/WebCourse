using System.Linq.Expressions;

namespace CourseDomain.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression);
        void Add(T entity); 
        void Update(T entity); 
        void Remove(T entity);
    }
}
