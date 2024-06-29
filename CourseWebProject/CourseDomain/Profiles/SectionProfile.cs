using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    public  class SectionProfile
    {
        public int SectionId { get; set; }
        public string Title { get; set; }

        public int LectureNumber {  get; set; }

        public TimeOnly Duration { get; set; }



    }
}
