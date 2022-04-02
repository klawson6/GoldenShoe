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
		public DbSet<ShoeColour> ShoeColours { get; set; }
		public DbSet<ShoeColourSize> ShoeColourSizes { get; set; }
		public DbSet<Style> Styles { get; set; }
		public DbSet<ShoeSize> ShoeSizes { get; set; }
		public DbSet<Colour> Colours { get; set; }
		public DbSet<Store> Stores { get; set; }
		public DbSet<ShoeColourSizeStock> ShoeStock { get; set; }

	}
}
