using AutoMapper;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>().
                ForMember(dest => dest.CategoryId, opt => opt.MapFrom(opt => opt.CategoryId)).
                                ForMember(dest => dest.Name, opt => opt.MapFrom(opt => opt.Name)).
                ForMember(dest => dest.Courses, opt => opt.MapFrom(opt => opt.Courses)).
                ReverseMap();




            ;

        }
    }
}
