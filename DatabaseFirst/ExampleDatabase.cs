using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst;

public class ExampleDatabase : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		optionsBuilder.UseSqlite("Data Source = ./ExampleDatabase.db"); //bisa pakai data source atau FileName
    }
}
