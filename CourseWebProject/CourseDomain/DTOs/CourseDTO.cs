﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class CourseDTO
    {
        public int CourseId { get; set; }
        public string? CategoryName { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public string? InstructorName { get; set; }
        public decimal? Price { get; set; }
        public int Sale { get; set; }

        public decimal? Rating { get; set; }
        public int RatingNumber { get; set; }
        public int StudentNumber { get; set; }

        public int SectionNumber { get; set; }
        public int LectureNumber { get; set; }
        public string  Duration { get; set; }

        public string Url {  get; set; }

    }

}
