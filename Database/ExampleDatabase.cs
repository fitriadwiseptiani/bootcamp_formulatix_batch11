using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;

namespace Database;
public  class ExampleDatabase : DbContext
{
	private string path = String.Empty;
	public DbSet<Product>? Products { get; set; }
	public DbSet<Category>? Categories { get; set; }
	public DbSet<Location>? Locations { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
		string connectionPath = $"Data Source={path}";
		optionsBuilder.UseSqlite(connectionPath);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>()
					.Property(c => c.CategoryName)
					.IsRequired()
					.HasMaxLength(15);

		modelBuilder.Entity<Category>()
					.Property(c => c.CategoryId)
					.HasMaxLength(6);
	}
}  
