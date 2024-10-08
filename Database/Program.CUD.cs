using Database;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProgramDatabase
{
	partial class Program
	{
		static async void AddCategory()
		{
			using (ExampleDatabase db = new())
			{
				SectionTitle("Adding a Category");

				Printer("Enter the category name : ");
				string? name = GetInput();
				Printer("Enter the category description : ");
				string? desc = GetInput();
				Category category = new Category
				{
					CategoryName = name,
					Description = desc,
				};
				db.Categories?.Add(category);
				await db.SaveChangesAsync();

				Info("Category added successfully.");
			}
		}
		
		static void AddLocation()
		{
			using (ExampleDatabase db = new())
			{
				SectionTitle("Adding a Category");

				Printer("Enter the Location name : ");
				string? name = GetInput();
				Location location = new Location
				{
					LocationName = name
				};
				db.Locations?.Add(location);
				db.SaveChanges();

				Info("Category added successfully.");
			}
		}



		static void AddProduct()
		{
			using (ExampleDatabase db = new())
			{
				SectionTitle("Adding a Product");

				Printer("Enter the product name: ");
				string? name = GetInput();

				Printer("Enter the product price: ");
				string? input = GetInput();
				decimal.TryParse(input, out decimal price);

				Printer("Enter the product stock level: ");
				input = GetInput();
				short.TryParse(input, out short stock);

				Printer("Enter the category ID: ");
				input = GetInput();
				int.TryParse(input, out int categoryId);

				Product product = new Product
				{
					ProductName = name,
					Cost = price,
					Stock = stock,
					CategoryId = categoryId
				};

				db.Products?.Add(product);
				db.SaveChanges();

				Info("Product added successfully.");
			}
		}

		static void UpdateProduct()
		{
			using (ExampleDatabase db = new())
			{
				SectionTitle("Updating a Product");

				Printer("Enter the product ID: ");
				string? input = GetInput();
				int.TryParse(input, out int id);

				Product? product = db.Products?.Find(id);

				if (product is null)
				{
					Fail("Product not found.");
					return;
				}

				Printer("Enter the new product name (leave empty to keep the existing name): ");
				string name = GetInput();

				if (!string.IsNullOrEmpty(name))
				{
					product.ProductName = name;
				}

				Printer("Enter the new product price (leave empty to keep the existing price): ");
				input = GetInput();

				if (!string.IsNullOrEmpty(input))
				{
					product.Cost = decimal.Parse(input);
				}

				Printer("Enter the new product stock level (leave empty to keep the existing stock level): ");
				input = GetInput();

				if (!string.IsNullOrEmpty(input))
				{
					product.Stock = short.Parse(input);
				}

				Printer("Enter the new category ID (leave empty to keep the existing category): ");
				input = GetInput();

				if (!string.IsNullOrEmpty(input))
				{
					product.CategoryId = int.Parse(input);
				}

				Printer("Enter the new location ID (leave empty to keep the existing category): ");
				input = GetInput();

				if (!string.IsNullOrEmpty(input))
				{
					product.LocationId = int.Parse(input);
				}

				db.SaveChanges();

				Info("Product updated successfully.");
			}
		}
		static void DeleteProducts()
		{
			using (ExampleDatabase db = new())
			{
				SectionTitle("Delete a Product");

				Printer("Enter the product name: ");
				string input = GetInput();
				
				IQueryable<Product>? products = db.Products?
												.Where(p => p.ProductName.StartsWith(input));
				
				if ((products is null) || (!products.Any()))
				{
					Fail("No products found to delete.");
					return;
				}
				else if (db.Products is null)
				{
					Fail ("Product is null");
					return;
				}	
				else
				{
					db.Products.RemoveRange(products);
					db.SaveChanges();
				}
			}
		}
	}
}
