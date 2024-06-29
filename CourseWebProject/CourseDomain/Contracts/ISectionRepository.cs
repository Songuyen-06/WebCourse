﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Contracts
{
    public  interface ISectionRepository
    {
        public IEnumerable<Section> GetSectionsByCourseId(int courdId);
    }
}
