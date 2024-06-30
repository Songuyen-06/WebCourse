using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class SectionDTO
    {
        public int SectionId { get; set; }
        public string Title { get; set; }

        public int LectureNumber { get; set; }

        public string Duration { get; set; }

        public List<LectureDTO> Lectures { get; set; }
    }
}
