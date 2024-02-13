using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
	public class EFCourseDal : GenericRepository<Course, NTierKodlamaDbContext>, ICourseDal
	{

		public List<Course> GetCourseWithInstructor()
		{
			using(var context = new NTierKodlamaDbContext())
			{
				return context.Courses.Include(x=>x.Instructor).ToList();
			}
		}

		public List<Course> GetCourseWithSearch(string word)
		{
			using (var context = new NTierKodlamaDbContext())
			{
				return context.Courses.Include(x => x.Instructor).Where(x=>x.Instructor.FirstName.Contains(word)||x.CourseName.Contains(word)).ToList();
			}
		}
	}
}
