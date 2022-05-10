using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImagineDreams.Models
{
    public class CreateSale
    {
        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Total { get; set; }

        [Required]
        public int UserIdBuyer { get; set; }

        [Required]
        public int ProductId { get; set; }

        public int StateId { get; set; }

    }
}