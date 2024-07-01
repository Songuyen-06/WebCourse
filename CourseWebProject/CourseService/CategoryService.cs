using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public class CategoryService : ICategoryService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        private readonly IMapper _mapper;


        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }



        public async Task<IEnumerable<Category>> GetListCategory()
        {
            return await _unitOfWork.CategoryRepository.GetAll();
        }


    }
}
