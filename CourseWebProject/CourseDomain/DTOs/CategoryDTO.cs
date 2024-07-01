using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; } = null!;


        public List<CourseDTO> Courses { get; set; }
    }
}
