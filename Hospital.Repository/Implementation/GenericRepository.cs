﻿using Hospital.Repositories.Interfaces;
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
		

		public GenericRepository(ApplicationDbContext context)
		{
			_context=context;
			dbSet=_context.Set<T>();
		}

		public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
		{
			IQueryable<T> query = dbSet;
			if(filter != null)
			{
				query = query.Where(filter);
			}
			foreach(var includeProperty in includeProperties.Split(new char[] {','}, 
				StringSplitOptions.RemoveEmptyEntries))
			{
				query=query.Include(includeProperty);
			}

			if(orderBy != null)
			{
				return orderBy(query).ToList();
			}
			else
			{

			}
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
			dbSet.Add(entity);
		}

		public async Task<T> AddAsync(T entity)
		{
            dbSet.Add(entity);
			return entity;
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
			if(_context.Entry(entity).State== EntityState.Detached)
			{
				dbSet.Attach(entity);
			}
			dbSet.Remove(entity);
		}

		public async Task <T> DeleteAsync(T entity)
		{
			if(_context.Entry(entity).State == EntityState.Detached)
			{
				dbSet.Attach(entity);
			}
			return entity;
		}
		private bool disposed = false;

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			this.disposed = true;
		}

        public object GetAll(object value)
        {
            throw new NotImplementedException();
        }
    }
}
