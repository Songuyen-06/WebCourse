using CourseDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Contracts
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        public Task<IEnumerable<Category>> GetListCategory();

    }
}
