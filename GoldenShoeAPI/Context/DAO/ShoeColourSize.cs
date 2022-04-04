using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("ShoeColourSizes")]
	public class ShoeColourSize
	{
		[Key]
		public int ShoeColourSizeId { get; set; }
		public ShoeColour ShoeColour { get; set; }
		public ShoeSize ShoeSize { get; set; }
		public bool Stocked { get; set; }
		public bool Reorder { get; set; }
		public bool Reordered { get; set; }
	}
}
