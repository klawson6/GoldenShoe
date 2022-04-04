using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("Colours")]
	public class Colour
	{
		[Key]
		public int ColourId { get; set; }
		public string Name { get; set; }
	}
}
