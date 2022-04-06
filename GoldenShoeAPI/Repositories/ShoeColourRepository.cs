using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class ShoeColourRepository: IShoeColourRepository
	{
		private readonly GoldenShoeContext _context;

		public ShoeColourRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(ShoeColour entity)
		{
			_context.ShoeColours.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(ShoeColour entity)
		{
			_context.ShoeColours.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<ShoeColour> FindAll()
		{
			return _context.ShoeColours.AsEnumerable();
		}

		public IEnumerable<ShoeColour> FindByCondition(Func<ShoeColour, bool> expression)
		{
			return _context.ShoeColours.AsEnumerable().Where(s => expression(s));
		}

		public ShoeColour FindByID(int id)
		{
			return _context.ShoeColours.AsEnumerable().First(s => s.ShoeColourId == id);
		}

		public void Update(ShoeColour entity)
		{
			_context.ShoeColours.Update(entity);
			_context.SaveChanges();
		}
	}
}
