using AutoMapper;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    public class SectionProfile : Profile
    {

        public SectionProfile()
        {
            CreateMap<Section, SectionDTO>().
                ForMember(dest => dest.SectionId, opt => opt.MapFrom(opt => opt.SectionId)).
                                ForMember(dest => dest.Title, opt => opt.MapFrom(opt => opt.Title)).
                ForMember(dest => dest.LectureNumber, opt => opt.MapFrom(opt => opt.Lectures.Count)).
                                ForMember(dest => dest.Duration, opt => opt.MapFrom(opt => opt.Duration)).

               ForMember(dest => dest.Lectures, opt => opt.MapFrom(opt => opt.Lectures)).ReverseMap();

        }


    }
}
