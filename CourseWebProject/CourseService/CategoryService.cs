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
        public IUnitOfWork _unitOfWork { get; set; }

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public async Task<IEnumerable<Category>> GetListCategory()
        {
            return await _unitOfWork.CategoryRepository.GetAll();
        }


    }
}
