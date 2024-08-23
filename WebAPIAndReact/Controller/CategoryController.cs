using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using WebAPIAndReact.Database;
using WebAPIAndReact.Models;


namespace WebAPIAndReact.Controller;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
	private readonly DataContext _db;
	public CategoryController(DataContext db)
	{
		_db = db;
	}
	[HttpGet]
	public IActionResult GetAll()
	{
		List<Category> categories = _db.Categories.ToList();
		return Ok(categories);
	}
	// [HttpPost]
	// public IActionResult GetById(Category category)
	// {

	// }
}
