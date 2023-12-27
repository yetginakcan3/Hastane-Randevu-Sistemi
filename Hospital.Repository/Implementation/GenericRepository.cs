using Hospital.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Repositories.Implementation
{
	public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context;
		internal DbSet<T> dbSet;
		private ApplicationDbContext context;

		public GenericRepository(ApplicationDbContext context)
		{
			this.context = context;
		}

		public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public T GetById(object id)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetByIdAsync(object id)
		{
			throw new NotImplementedException();
		}

		public void Add(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<T> AddAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public void Update(T entity)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
