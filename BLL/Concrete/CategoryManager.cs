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
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Add(Category t)
		{
			_categoryDal.Insert(t);
		}

		public void Delete(Category t)
		{
			_categoryDal.Delete(t);
		}

		public List<Category> GetAll()
		{
		return	_categoryDal.GetAll();
		}

		public Category GetById(int id)
		{
			return _categoryDal.Get(x => x.Id == id);
		}

		public void Update(Category t)
		{
			_categoryDal.Update(t);
		}
	}
}
