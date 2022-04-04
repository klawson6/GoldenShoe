using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenShoeAPI.Context
{
	[Table("Stores")]
	public class Store
	{
		[Key]
		public int StoreId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Postcode { get; set; }
		public string PhoneNumber { get; set; }
		public string EmailAddress { get; set; }
	}
}
