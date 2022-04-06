using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Domain
{
	[Table("Brands")]
	public class Brand
	{
		[Key]
		public int BrandId { get; set; }
		public string Name { get; set; }
	}
}
