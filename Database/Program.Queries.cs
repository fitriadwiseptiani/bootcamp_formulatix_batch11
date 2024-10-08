using Database;
using Microsoft.EntityFrameworkCore;
namespace ProgramDatabase;

partial class Program
{
	static void QueryingCategories()
	{
		using (ExampleDatabase db = new())
		{
			SectionTitle("Querying Categories and Products");

			IQueryable<Category>? categories = db.Categories?
												.Include(c => c.Products); //Eager loading

			if ((categories == null) || (!categories.Any()))
			{
				Fail("No Categories Found");
				return;
			}
			Info($"ToQueryString: {categories.ToQueryString()}"); //Print SQL command
			foreach (Category? c in categories)
			{
				Printer($"Category: {c.CategoryName} has {c.Products.Count} products.");
			}
		}
	}

	static void FilteredIncludes()
	{
		using (ExampleDatabase db = new())
		{
			SectionTitle("Filtered Includes");
			string? input;
			int stock;

			do
			{
				Printer("Enter a product stock level: ");
				input = GetInput();
			}
			while (!int.TryParse(input, out stock));

			IQueryable<Category>? categories = db.Categories?
												.Include(c => c.Products.Where(p => p.Stock >= stock));

			if ((categories == null) || (!categories.Any()))
			{
				Fail("No Categories Found");
				return;
			}
			Info($"ToQueryString: {categories.ToQueryString()}");
			foreach (Category? c in categories)
			{
				Info($"Category: {c.CategoryName} has {c.Products.Count} products with minimum {stock}.");

				foreach (Product? p in c.Products)
				{
					Printer($"\t{p.ProductName} has {p.Stock} in stock.");
				}
			}
		}
	}

	static void QueryingProducts()
	{
		using (ExampleDatabase db = new())
		{
			SectionTitle("Products that cost more than a price, highest at top.");

			string? input;
			decimal price;
			do
			{
				Printer("Enter a product price: ");
				input = GetInput();
			} while (!decimal.TryParse(input, out price));

			var products = db.Products?
							.Where(product => product.Cost > price)
							.OrderByDescending(product => product.Cost);

			if ((products is null) || (!products.Any()))
			{
				Fail("No products found.");
				return;
			}
			Info($"ToQueryString: {products.ToQueryString()}");
			foreach (Product p in products)
			{
				Printer($"{p.ProductId}: {p.ProductName} costs {p.Cost:$#,##0.00} and has {p.Stock} in stock.");
			}
		}
	}

	static void ShowProductByLocation()
	{
		using (ExampleDatabase db = new())
		{
			Printer("Enter the location name: ");
			string input = GetInput();

            Location? location = db.Locations?.FirstOrDefault(d => d.LocationName == input);
			if (location == null)
			{
				Printer("Not found");
				return;
			}
            IQueryable<Product>? products = db.Products?.Where(d => d.LocationId == location.LocationId);
			if (products == null)
			{
				Printer("Not found");
				return;
			}
			Printer($"Here is location of {location.LocationName}");
			foreach (var x in products)
			{
				Printer($"{x.ProductId}: {x.ProductName} costs {x.Cost:$#,##0.00} and has {x.Stock} in stock.");
			}
		}
	}
}
