using System.ComponentModel.DataAnnotations;

namespace ImagineDreams.Request
{
    public class ProductCreateRequest
    {
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

        public int CategoryId { get; set; } = default!;
    }
}
//Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=imaginedreams' Microsoft.EntityFrameworkCore.SqlServer
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer

//dotnet ef dbcontext scaffold "Server=.\;Database=services-net;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model
//dotnet ef dbcontext scaffold "Server=localhost;Database=imaginedreams;User=root;Password=;" Microsoft.EntityFrameworkCore.SqlServer -o Model