﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		T Get(Expression<Func<T, bool>> filter);
		void Insert(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}
