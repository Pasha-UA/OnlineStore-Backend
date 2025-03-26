using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Application.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255, ErrorMessage = "Name cannot exceed 255 characters.")]
        public string Name { get; set; }

        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string? Description { get; set; } // Nullable

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be a non-negative number.")]
        public int StockQuantity { get; set; }

        public string? ImageUrl { get; set; } // Nullable

        // Add other properties as needed (e.g., CategoryId, BrandId, etc.)
    }
}