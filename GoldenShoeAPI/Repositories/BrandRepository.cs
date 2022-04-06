using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class BrandRepository: IBrandRepository
	{
		private readonly GoldenShoeContext _context;

		public BrandRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(Brand entity)
		{
			_context.Brands.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Brand entity)
		{
			_context.Brands.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<Brand> FindAll()
		{
			return _context.Brands.AsEnumerable();
		}

		public IEnumerable<Brand> FindByCondition(Func<Brand, bool> expression)
		{
			return _context.Brands.AsEnumerable().Where(s => expression(s));
		}

		public Brand FindByID(int id)
		{
			return _context.Brands.AsEnumerable().First(s => s.BrandId == id);
		}

		public void Update(Brand entity)
		{
			_context.Brands.Update(entity);
			_context.SaveChanges();
		}
	}
}
