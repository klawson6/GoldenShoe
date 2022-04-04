using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("Shoes")]
	public class Shoe
	{
		[Key]
		public int ShoeId { get; set; }
		public string Name { get; set; }
		public Brand Brand { get; set; }
		public string Description { get; set; }
		public Style Style { get; set; }
		public double Price { get; set; }
	}
}
