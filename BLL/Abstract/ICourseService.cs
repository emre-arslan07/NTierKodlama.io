﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
	public interface ICourseService:IGenericService<Course>
	{
	  List<Course> GetCourseWithInstructor();
		List<Course> GetCourseWithSearch(string word);
	}
}