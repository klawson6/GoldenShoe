using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Domain
{
	[Table("Styles")]
	public class Style
	{
		[Key]
		public int StyleId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
