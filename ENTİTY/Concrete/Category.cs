using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Category:BaseClass
	{
        public string CategoryName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
