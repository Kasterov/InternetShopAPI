using InternetShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShopAPI.DataBase;

public class ApiDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Product.db");
    }
}
