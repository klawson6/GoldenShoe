using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("Brands")]
	public class Brand
	{
		[Key]
		public int BrandId { get; set; }
		public string Name { get; set; }
	}
}
