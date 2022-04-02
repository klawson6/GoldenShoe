using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("Shoes")]
	public class Shoe
	{
		[Key]
		public Guid ShoeId { get; set; }
		public string Name { get; set; }
		public string Brand { get; set; }
		public string Description { get; set; }
		public Guid StyleId { get; set; }
		public double Price { get; set; }
	}
}
