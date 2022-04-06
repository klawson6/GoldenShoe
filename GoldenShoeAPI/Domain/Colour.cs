using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Domain
{
	[Table("Colours")]
	public class Colour
	{
		[Key]
		public int ColourId { get; set; }
		public string Name { get; set; }
	}
}
