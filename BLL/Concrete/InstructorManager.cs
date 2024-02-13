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
	public class InstructorManager : IInstructorService
	{
		private readonly IInstructorDal _instructorDal;

		public InstructorManager(IInstructorDal instructorDal)
		{
			_instructorDal = instructorDal;
		}

		public void Add(Instructor t)
		{
			_instructorDal.Insert(t);
		}

		public void Delete(Instructor t)
		{
			_instructorDal.Delete(t);
		}

		public List<Instructor> GetAll()
		{
			return _instructorDal.GetAll();
		}

		public Instructor GetById(int id)
		{
			return _instructorDal.Get(x=>x.Id== id);
		}

		public void Update(Instructor t)
		{
			_instructorDal.Update(t);
		}
	}
}
