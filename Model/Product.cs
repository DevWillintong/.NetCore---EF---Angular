using System;
using System.Collections.Generic;

namespace ImagineDreams.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public string Price { get; set; } = null!;
        public int Stock { get; set; }
        public DateOnly CreatedDate { get; set; }
        public DateOnly UpdatedDate { get; set; }
        public int CreatorId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual User Creator { get; set; } = null!;
    }
}
