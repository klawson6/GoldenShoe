using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("ShoeSizes")]
	public class ShoeSize
	{
		[Key]
		public int SizeId { get; set; }
		public double Size { get; set; }
		public string Region { get; set; }
	}
}
