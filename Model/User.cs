using System;
using System.Collections.Generic;

namespace ImagineDreams.Model
{
    public partial class User
    {
        public User()
        {
            Products = new HashSet<Product>();
        }

        public int UserId { get; set; }
        public string Fullname { get; set; } = null!;
        public DateOnly CreatedDate { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
