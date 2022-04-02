using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("Styles")]
	public class Style
	{
		[Key]
		public Guid StyleId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
