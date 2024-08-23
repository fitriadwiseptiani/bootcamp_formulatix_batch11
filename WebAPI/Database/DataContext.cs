namespace WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions options) : base(options)
	{
		
	}
	public DbSet<Product> Products {get; set;}
	public DbSet<Category> Categories{get; set;}
}
