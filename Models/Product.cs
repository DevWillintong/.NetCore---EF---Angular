using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImagineDreams.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60), Required]
        public string Name { get; set; } = default!;

        [StringLength(255), Required]
        public string? Description { get; set; }

        [Required]
        public string Img { get; set; } = string.Empty;

        [Required]
        public float Price { get; set; } = default!;

        [Required]
        public int Stock { get; set; } = default!;

        public int UserId { get; set; }

        public int CategoryId { get; set; }
    }

}