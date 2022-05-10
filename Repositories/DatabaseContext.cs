using Microsoft.EntityFrameworkCore;
using ImagineDreams.Models;



namespace ImagineDreams.Repositories
{
    public class DatabaseConentext : DbContext
    {
        public DatabaseConentext(DbContextOptions<DatabaseConentext> options) : base(options)
        {  }
        
        public DbSet<UserEntity> Users { get; set; } = default!;

        public DbSet<ProductEntity> Products { set; get; } = default!;

        public DbSet<CategoryEntity> Categorys { set; get; } = default!;

        public DbSet<SalesEntity> Sales { set; get; } = default!;

        public DbSet<StatesSale> StatesSale { set; get; } = default!;

    }
}

//dotnet ef dbcontext scaffold "Server=localhost;Database=kibo;User=root;Password=;" Microsoft.EntityFrameworkCore -o Model
//dotnet ef dbcontext scaffold "Server=localhost;Database=kibo;User=root;Password=;" MySql.EntityFrameworkCore -o Model
//dotnet ef dbcontext scaffold "Server=localhost;Database=kibo;User=root;Password=;" Pomelo.EntityFrameworkCore.MySql -o Model -f

