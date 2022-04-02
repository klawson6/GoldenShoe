using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("ShoeSizes")]
	public class ShoeSize
	{
		[Key]
		public Guid SizeId { get; set; }
		public int Size { get; set; }
	}
}
