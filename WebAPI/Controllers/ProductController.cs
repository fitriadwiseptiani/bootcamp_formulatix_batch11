using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Database;

namespace WebAPI.Controllers;

public class ProductController : IController<Product>
{
	public IActionResult Create(Product data)
	{
		throw new NotImplementedException();
	}

	public IActionResult Delete(int id)
	{
		throw new NotImplementedException();
	}

	public IActionResult Get()
	{
		throw new NotImplementedException();
	}

	public IActionResult Get(int id)
	{
		throw new NotImplementedException();
	}

	public IActionResult Update(int id, Product data)
	{
		throw new NotImplementedException();
	}

}
