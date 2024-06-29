using CourseDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public  class CategoryService : ICategoryService
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public CategoryService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }



        public List<Category> GetListCategory()
        {
            return UnitOfWork.ICategoryRepository.GetAll().ToList();
        }


    }
}
