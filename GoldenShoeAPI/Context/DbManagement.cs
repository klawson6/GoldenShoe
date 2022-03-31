using System;

namespace GoldenShoeAPI.Context
{
	public class DbManagement
	{
		private readonly GoldenShoeContext _context;

		public DbManagement(GoldenShoeContext context)
		{
			_context = context;
			TeardownDatabase();
			InitialiseDatabase();
		}

		private void InitialiseDatabase()
		{
			_context.Database.EnsureCreated();
			_context.Shoes.Add(new Shoe { Id = Guid.NewGuid(), Name = "AirForce", Brand = "Nike", Description = "Really popular.", Price = 79.99, Type = "Trainers" });
			_context.Shoes.Add(new Shoe { Id = Guid.NewGuid(), Name = "700", Brand = "New Balance", Description = "I like.", Price = 59.99, Type = "Trainers" });
			_context.SaveChanges();
		}

		private void TeardownDatabase()
		{
			_context.Database.EnsureDeleted();
			_context.SaveChanges();
		}
	}
}
