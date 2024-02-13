using DAL.Abstract;
using DAL.Concrete;
using ENTİTY.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class GenericRepository<T, TContext> :IGenericDal<T> where T : class,IEntity,new()
		where TContext : DbContext,new()
	{
		TContext _context = new TContext();

		public void Delete(T entity)
		{
			var deletedEntity = _context.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			_context.SaveChanges();
		}

		public T Get(Expression<Func<T, bool>> filter)
		{
			return _context.Set<T>().SingleOrDefault(filter);
		}

		public List<T> GetAll(Expression<Func<T, bool>> filter = null)
		{
			return filter == null ?
					_context.Set<T>().ToList() :
					_context.Set<T>().Where(filter).ToList();
		}

		public void Insert(T entity)
		{
			var addedEntity = _context.Entry(entity);
			addedEntity.State = EntityState.Added;
			_context.SaveChanges();
		}

		public void Update(T entity)
		{
			var updatedEntity = _context.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			_context.SaveChanges();
		}
	}
}
