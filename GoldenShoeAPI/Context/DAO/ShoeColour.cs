using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("ShoeColours")]
	public class ShoeColour
	{
		[Key]
		public int ShoeColourId { get; set; }
		public Shoe Shoe { get; set; }
		public Colour Colour { get; set; }
		public bool Available { get; set; }
	}
}
