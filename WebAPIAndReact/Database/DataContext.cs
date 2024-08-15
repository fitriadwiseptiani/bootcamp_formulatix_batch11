namespace WebAPIAndReact.Database;
using Microsoft.EntityFrameworkCore;
using WebAPIAndReact.Models;


public class DataContext : DbContext
{
	public DataContext(DbContextOptions options) : base(options)
	{
		
	}
	public DbSet<Category> Categories{ get; set; }
	public DbSet<Product> Products{ get; set;}
}
