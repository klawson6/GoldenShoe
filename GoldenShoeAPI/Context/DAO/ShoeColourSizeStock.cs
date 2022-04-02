using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("ShoeStock")]
	public class ShoeColourSizeStock
	{
		[Key]
		public Guid ShoeColourSizeStockId { get; set; }
		public ShoeColourSize ShoeColourSize { get; set; }
		public Store StoreId { get; set; }
		public int quantity { get; set; }
	}
}
