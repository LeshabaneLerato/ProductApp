using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;

		[Required]
		public decimal Price { get; set; }

		[MaxLength(500)]
		public string? Description { get; set; }
	}
}