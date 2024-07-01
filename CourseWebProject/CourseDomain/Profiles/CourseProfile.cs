using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CourseDomain.DTOs;

namespace CourseDomain.Profiles
{
    public class CourseProfile : Profile
    {

        public CourseProfile()
        {
            CreateMap<Course, CourseDTO>()
                    .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.CourseId))
                           .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))

                    .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                                     .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))

                    .ForMember(dest => dest.InstructorName, opt => opt.MapFrom(src => src.Instructor.FullName))
         .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
        .ForMember(dest => dest.PriceAfterSale, opt => opt.MapFrom(src => src.Price - ((decimal)0.01 * src.Sale * src.Price) ))

                       .ForMember(dest => dest.Sale, opt => opt.MapFrom(src => src.Sale))

        .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Reviews.Any() ? src.Reviews.Average(r => r.Rating) : 0))
        .ForMember(dest => dest.RatingNumber, opt => opt.MapFrom(src => src.Reviews.Count()))
            .ForMember(dest => dest.StudentNumber, opt => opt.MapFrom(src => src.StudentCourses.Count))

                          .ForMember(dest => dest.SectionNumber, opt => opt.MapFrom(src => src.Sections.Count))
              .ForMember(dest => dest.LectureNumber, opt => opt.MapFrom(src => src.Sections.Sum(s=>s.Lectures.Count)))

              .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                            .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))



     .ReverseMap();


        }
    }
}

