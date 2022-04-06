using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class StoreRepository: IStoreRepository
	{
		private readonly GoldenShoeContext _context;

		public StoreRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(Store entity)
		{
			_context.Stores.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Store entity)
		{
			_context.Stores.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<Store> FindAll()
		{
			return _context.Stores.AsEnumerable();
		}

		public IEnumerable<Store> FindByCondition(Func<Store, bool> expression)
		{
			return _context.Stores.AsEnumerable().Where(s => expression(s));
		}

		public Store FindByID(int id)
		{
			return _context.Stores.AsEnumerable().First(s => s.StoreId == id);
		}

		public void Update(Store entity)
		{
			_context.Stores.Update(entity);
			_context.SaveChanges();
		}
	}
}
