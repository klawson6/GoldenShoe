using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class StyleRepository: IStyleRepository
	{
		private readonly GoldenShoeContext _context;

		public StyleRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(Style entity)
		{
			_context.Styles.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Style entity)
		{
			_context.Styles.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<Style> FindAll()
		{
			return _context.Styles.AsEnumerable();
		}

		public IEnumerable<Style> FindByCondition(Func<Style, bool> expression)
		{
			return _context.Styles.AsEnumerable().Where(s => expression(s));
		}

		public Style FindByID(int id)
		{
			return _context.Styles.AsEnumerable().First(s => s.StyleId == id);
		}

		public void Update(Style entity)
		{
			_context.Styles.Update(entity);
			_context.SaveChanges();
		}
	}
}
