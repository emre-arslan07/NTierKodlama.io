﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Instructor:BaseClass
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
