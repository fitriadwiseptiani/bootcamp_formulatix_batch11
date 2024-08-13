
using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public class Data : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products{ get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=apapun;Username=postgres;Password=postgres");
	}
}
