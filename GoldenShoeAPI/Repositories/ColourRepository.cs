using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class ColourRepository: IColourRepository
	{
		private readonly GoldenShoeContext _context;

		public ColourRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(Colour entity)
		{
			_context.Colours.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Colour entity)
		{
			_context.Colours.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<Colour> FindAll()
		{
			return _context.Colours.AsEnumerable();
		}

		public IEnumerable<Colour> FindByCondition(Func<Colour, bool> expression)
		{
			return _context.Colours.AsEnumerable().Where(s => expression(s));
		}

		public Colour FindByID(int id)
		{
			return _context.Colours.AsEnumerable().First(s => s.ColourId == id);
		}

		public void Update(Colour entity)
		{
			_context.Colours.Update(entity);
			_context.SaveChanges();
		}
	}
}
