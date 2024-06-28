using CourseDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    internal interface ICategoryService
    {
        public List<Category> GetCategories();

    }
}
