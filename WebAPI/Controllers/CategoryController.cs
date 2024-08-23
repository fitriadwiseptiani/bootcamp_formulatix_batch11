// using Microsoft.AspNetCore.Http.HttpResults;
// using Microsoft.AspNetCore.Mvc;

// namespace WebAPI.Controllers;

// [Route("api/[controller]")]
// [ApiController]
// public class CategoryController :ControllerBase
// {
// 	private static readonly List<string> myCategories = new() {"teddy", "bear"};
	
// 	[HttpGet]
// 	public IActionResult GetAll()
// 	{
// 		return Ok(myCategories);
// 	}
// 	[Route("{id}")]
// 	[HttpGet]
// 	public IActionResult GetAll(int id)
// 	{
// 		if(id > myCategories.Count)
// 		{
// 			return NotFound("Tidak bisa");
// 		}
// 		return Ok(myCategories[id]);
// 	}
// 	[HttpPost]
// 	public IActionResult Add(string data)
// 	{
// 		myCategories.Add(data);
// 		return Ok(myCategories);
// 	}
// 	[Route("{id}")]
// 	[HttpDelete]
// 	public IActionResult Delete(int id)
// 	{
// 		if(id > myCategories.Count)
// 		{
// 			return NotFound("Tidak bisa");
// 		}
// 		myCategories.RemoveAt(id);
// 		return Ok(myCategories);
		
// 	}
// 	[Route("{id}")]
//     [HttpPut]
//     public IActionResult Update(int id, string newCategory)
//     {
//         myCategories[id] = newCategory;
//         return Ok(myCategories);
//     }
// }


// versi database
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Database;
using WebAPI.Models;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase, IController<Category>
{
	private readonly DataContext _db;
	public CategoryController(DataContext db)
	{
		_db = db;
	}
	[HttpPost]
	public IActionResult Create(Category data)
	{
		_db.Categories.Add(data);
		_db.SaveChanges();
		return Ok();
	}
	[HttpDelete]
	[Route("{id}")]
	public IActionResult Delete(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category is null ) {
			return NotFound();
		}
		_db.Categories.Remove(category);
		_db.SaveChanges();
		return Ok();
	}
	[HttpGet]
	public IActionResult Get()
	{
		List<Category> categories = _db.Categories.ToList();
		return Ok(categories);
	}
	[HttpGet]
	[Route("{id}")]
	public IActionResult Get(int id)
	{
		Category? category = _db.Categories.Find(id);
		if(category is null ) {
			return NotFound();
		}
		return Ok(category);
	}
	[HttpPut]
	[Route("{id}")]
	public IActionResult Update(int id, Category data)
	{
		Category? category = _db.Categories.Find(id);
		if(category is null ) {
			return NotFound();
		}
		category.CategoryName = data.CategoryName;
		category.Description = data.Description;
		_db.Categories.Update(category);
		_db.SaveChanges();
		return Ok();
	}

}