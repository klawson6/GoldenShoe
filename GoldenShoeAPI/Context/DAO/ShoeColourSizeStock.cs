using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("ShoeStock")]
	public class ShoeColourSizeStock
	{
		[Key]
		public int ShoeColourSizeStockId { get; set; }
		public ShoeColourSize ShoeColourSize { get; set; }
		public Store Store { get; set; }
		public int Quantity { get; set; }
	}
}
