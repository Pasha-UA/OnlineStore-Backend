using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Infrastructure.Data.Entities
{
    [Table("Products")] // Optional: Specifies the table name in the database
    public class Product
    {
        [Key] // Indicates that this is the primary key
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")] // Specifies the data type in the database
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        [StringLength(2048)] //Adjust the length as needed
        public string? ImageUrl { get; set; }

        // Relationships with other entities (if any)
        // Example:
        // public int CategoryId { get; set; }
        // public Category Category { get; set; }

        // Add other properties as needed
    }
}