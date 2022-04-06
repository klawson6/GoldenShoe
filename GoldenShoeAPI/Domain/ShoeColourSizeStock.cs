using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Domain
{
	[Table("ShoeStock")]
	public class ShoeColourSizeStock
	{
		[Key]
		public int ShoeColourSizeStockId { get; set; }
		public virtual ShoeColourSize ShoeColourSize { get; set; }
		public virtual Store Store { get; set; }
		public int Quantity { get; set; }
	}
}
