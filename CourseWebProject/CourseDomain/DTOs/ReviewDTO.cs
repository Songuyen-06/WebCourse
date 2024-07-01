using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class ReviewDTO
    {
        [Key]
        public int ReviewId { get; set; }

        public string StudentName { get; set; }


        public decimal Rating { get; set; }

        public string? Comment { get; set; }

        public string  ReviewDate { get; set; }
    }
}
