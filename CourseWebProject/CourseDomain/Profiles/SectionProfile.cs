﻿using AutoMapper;
using CourseDomain.DTOs;
using System;
using System.Linq;

namespace CourseDomain.Profiles
{
    public class SectionProfile : Profile
    {
        public SectionProfile()
        {
            CreateMap<Section, SectionDTO>()
                .ForMember(dest => dest.SectionId, opt => opt.MapFrom(src => src.SectionId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.LectureNumber, opt => opt.MapFrom(src => src.Lectures.Count))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => CalculateTotalDuration(src.Lectures.ToList())))
                .ForMember(dest => dest.Lectures, opt => opt.MapFrom(src => src.Lectures))
                .ReverseMap();
        }

        private string CalculateTotalDuration(List<Lecture> lectures)
        {
            TimeSpan totalDuration = TimeSpan.Zero;
            foreach (var lecture in lectures)
            {
                if (TimeSpan.TryParse(lecture.Duration, out TimeSpan lectureDuration))
                {
                    totalDuration += lectureDuration;
                }
            }
            return totalDuration.ToString(@"hh\:mm\:ss");
        }
    }
}
