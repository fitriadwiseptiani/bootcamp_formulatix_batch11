﻿
using Database;

namespace ProgramDatabase;
public partial class Program
{
	static async Task Main()
	{
		// Northwind db = new Northwind();
		// Console.WriteLine(db.Database.ProviderName);
		// MenuProgram();
		await Trial();
	}

	static void MenuProgram()
	{
		string? input;
		bool isValidInput = false;
		Console.Clear();
		while (!isValidInput)
		{
			Console.WriteLine("1) Querying Categories and Products");
			Console.WriteLine("2) Filtered Includes");
			Console.WriteLine("3) Querying Products");
			Console.WriteLine("4) Adding a Category");
			Console.WriteLine("5) Adding a Product");
			Console.WriteLine("6) Updating a Product");
			Console.WriteLine("7) Deleting a Product");
			Console.WriteLine("8) Add a Location");
			Console.WriteLine("9) Show loc");

			Console.WriteLine("X) Exit");
			Console.Write("Enter a command: ");
			input = GetInput();

			switch (input?.ToLower())
			{
				case "1":
					QueryingCategories();
					break;
				case "2":
					FilteredIncludes();
					break;
				case "3":
					QueryingProducts();
					break;
				case "4":
					AddCategory();
					break;
				case "5":
					AddProduct();
					break;
				case "6":
					UpdateProduct();
					break;
				case "7":
					DeleteProducts();
					break;
				case "8":
					AddLocation();
					break;
				case "9":
					ShowProductByLocation();
					break;
				case "x":
					isValidInput = true;
					break;
				default:
					Console.WriteLine("Invalid input. Please try again.");
					break;
			}
		}
	}
}
