using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Domain
{
	[Table("ShoeColours")]
	public class ShoeColour
	{
		[Key]
		public int ShoeColourId { get; set; }
		public virtual Shoe Shoe { get; set; }
		public virtual Colour Colour { get; set; }
		public bool Available { get; set; }
	}
}
