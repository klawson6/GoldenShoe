using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Domain
{
	[Table("ShoeColourSizes")]
	public class ShoeColourSize
	{
		[Key]
		public int ShoeColourSizeId { get; set; }
		public virtual ShoeColour ShoeColour { get; set; }
		public virtual ShoeSize ShoeSize { get; set; }
		public bool Stocked { get; set; }
		public bool Reorder { get; set; }
		public bool Reordered { get; set; }
	}
}
