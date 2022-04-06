using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class ShoeColourSizeStockRepository : IShoeColourSizeStockRepository
	{
		private readonly GoldenShoeContext _context;

		public ShoeColourSizeStockRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(ShoeColourSizeStock entity)
		{
			_context.ShoeStock.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(ShoeColourSizeStock entity)
		{
			_context.ShoeStock.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<ShoeColourSizeStock> FindAll()
		{
			return _context.ShoeStock.AsEnumerable();
		}

		public IEnumerable<ShoeColourSizeStock> FindByCondition(Func<ShoeColourSizeStock, bool> expression)
		{
			return _context.ShoeStock.AsEnumerable().Where(s => expression(s));
		}

		public ShoeColourSizeStock FindByID(int id)
		{
			return _context.ShoeStock.AsEnumerable().First(s => s.ShoeColourSizeStockId == id);
		}

		public void Update(ShoeColourSizeStock entity)
		{
			_context.ShoeStock.Update(entity);
			_context.SaveChanges();
		}
	}
}
