using BLL.Abstract;
using DAL.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
	public class CourseManager : ICourseService
	{
		private readonly ICourseDal _courseDal;

		public CourseManager(ICourseDal courseDal)
		{
			_courseDal = courseDal;
		}

		public void Add(Course t)
		{
			_courseDal.Insert(t);
		}

		public void Delete(Course t)
		{
			_courseDal.Delete(t);
		}

		public List<Course> GetAll()
		{
		return	_courseDal.GetAll();
		}

		public Course GetById(int id)
		{
			return _courseDal.Get(x => x.Id==id);
		}

		public List<Course> GetCourseWithInstructor()
		{
			return _courseDal.GetCourseWithInstructor();
		}

		public List<Course> GetCourseWithSearch(string word)
		{
			return _courseDal.GetCourseWithSearch(word);
		}

		public void Update(Course t)
		{
			_courseDal.Update(t);
		}
	}
}
