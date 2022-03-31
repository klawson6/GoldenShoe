using GoldenShoeAPI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class ShoeRepository: IShoeRepository
	{
		private readonly GoldenShoeContext _context;

		public ShoeRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(Shoe entity)
		{
			_context.Shoes.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Shoe entity)
		{
			_context.Shoes.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<Shoe> FindAll()
		{
			return _context.Shoes;
		}

		public IEnumerable<Shoe> FindByCondition(Func<Shoe, bool> expression)
		{
			return _context.Shoes.Where(s => expression(s));
		}

		public Shoe FindByID(Guid id)
		{
			return _context.Shoes.First(s => s.Id == id);
		}

		public void Update(Shoe entity)
		{
			_context.Shoes.Update(entity);
			_context.SaveChanges();
		}
	}
}
