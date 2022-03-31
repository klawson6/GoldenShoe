using Microsoft.EntityFrameworkCore;

namespace GoldenShoeAPI.Context
{
	public class GoldenShoeContext: DbContext
	{
		public GoldenShoeContext(DbContextOptions<GoldenShoeContext> options) : base(options) {
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Shoe> Shoes { get; set; }
	}
}
