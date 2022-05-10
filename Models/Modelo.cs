using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImagineDreams.Models
{
    public class UserEntity
    {
        [Key,]
        public int? Id { get; set; }

        [StringLength(60)]
        public string Fullname { get; set; } = string.Empty;

        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        public DateTime Created_Date { get; set; } = DateTime.Now;

        [InverseProperty("UserId")]
        public ICollection<ProductEntity> Product { get; set; } = default!;

        [InverseProperty("UserId")]
        public ICollection<SalesEntity> Sale { get; set; } = default!;

        public UserEntity ToModel()
        {
            return new UserEntity()
            {
                Fullname = Fullname,
                Email = Email,
                Password = "************"
            };
        }
    }


    public class ProductEntity
    {
        [Key]
        public int? Id { get; set; }

        [StringLength(60), Required(ErrorMessage = "The Name must be specified.")]
        public string Name { get; set; } = default!;

        [StringLength(255), Required]
        public string? Description { get; set; }

        [Required]
        public string Img { get; set; } = string.Empty;

        [Required]
        public float Price { get; set; } = default!;

        [Required]
        public int Stock { get; set; } = default!;

        public DateTime Created_Date { get; set; } = DateTime.Now;

        public DateTime Update_Date { get; set; } = DateTime.Now;

        public UserEntity UserId { get; set; } = default!;

        public CategoryEntity CategoryId { get; set; } = default!;
    }

    public class SalesEntity
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Total { get; set; }

        public DateTime Created_date { get; set; }

        public UserEntity UserId { get; set; } = default!;

        public ProductEntity ProductId { get; set; } = default!;

        public StatesSale StateId { get; set; } = default!;
    }

    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(255)]
        public string Description { get; set; } = string.Empty;

        //[InverseProperty(nameof(ProductEntity.CategoryId))]
        public ICollection<ProductEntity> Product { get; set; } = default!;
    }



}