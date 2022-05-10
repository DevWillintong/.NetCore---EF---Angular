using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImagineDreams.Models
{
    public class UsersModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60)]
        public string Fullname { get; set; } = default!;

        [StringLength(100)]
        public string Email { get; set; } = default!;

        [StringLength(60)]
        public string Password { get; set; } = default!;

        public DateTime Created_Date { get; set; } = DateTime.Now;
    }
}