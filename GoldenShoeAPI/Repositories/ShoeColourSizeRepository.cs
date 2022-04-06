using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class ShoeColourSizeRepository: IShoeColourSizeRepository
	{
		private readonly GoldenShoeContext _context;

		public ShoeColourSizeRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(ShoeColourSize entity)
		{
			_context.ShoeColourSizes.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(ShoeColourSize entity)
		{
			_context.ShoeColourSizes.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<ShoeColourSize> FindAll()
		{
			return _context.ShoeColourSizes.AsEnumerable();
		}

		public IEnumerable<ShoeColourSize> FindByCondition(Func<ShoeColourSize, bool> expression)
		{
			return _context.ShoeColourSizes.AsEnumerable().Where(s => expression(s));
		}

		public ShoeColourSize FindByID(int id)
		{
			return _context.ShoeColourSizes.AsEnumerable().First(s => s.ShoeColourSizeId == id);
		}

		public void Update(ShoeColourSize entity)
		{
			_context.ShoeColourSizes.Update(entity);
			_context.SaveChanges();
		}
	}
}
