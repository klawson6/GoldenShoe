using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class ShoeSizeRepository : IShoeSizeRepository
	{
		private readonly GoldenShoeContext _context;

		public ShoeSizeRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(ShoeSize entity)
		{
			_context.ShoeSizes.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(ShoeSize entity)
		{
			_context.ShoeSizes.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<ShoeSize> FindAll()
		{
			return _context.ShoeSizes.AsEnumerable();
		}

		public IEnumerable<ShoeSize> FindByCondition(Func<ShoeSize, bool> expression)
		{
			return _context.ShoeSizes.AsEnumerable().Where(s => expression(s));
		}

		public ShoeSize FindByID(int id)
		{
			return _context.ShoeSizes.AsEnumerable().First(s => s.SizeId == id);
		}

		public void Update(ShoeSize entity)
		{
			_context.ShoeSizes.Update(entity);
			_context.SaveChanges();
		}
	}
}
