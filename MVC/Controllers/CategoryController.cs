using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Databases;

namespace MVC.Controllers;

public class CategoryController : Controller
{
	private readonly DataContext _db;
	public CategoryController(DataContext db)
	{
		_db = db;
	}
	public ActionResult Index()
	{
		List<Category> categories = _db.Categories.ToList();
		return View(categories);
	}
	
	// Create
	public IActionResult Create()
	{
		return View();
	}
	// agar program mengenali kode sebagai action yang berbeda walau namanya sama
	[HttpPost]
	public IActionResult Create(Category category)
	{
		bool status = _db.Categories.Any(p => p.CategoryName == category.CategoryName);
		if(status)
		{
			Tempdata["Error"] = "Category already exist";
			return RedirectToAction("Index");
		}
		_db.Categories.Add(category);
		_db.SaveChanges();
		
		Tempdata["Success"] = "Create Category success";
		return RedirectToAction("Index");
	}
	public IActionResult Update(int? id)
	{
		if(id == null)
		{
			return NotFound();
		}
		Category category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		return View(category);
	}
	// agar program mengenali kode sebagai action yang berbeda walau namanya sama
	[HttpPost]
	public IActionResult Update(Category category)
	{
		_db.Categories.Update(category);
		_db.SaveChanges();
		return RedirectToAction("Index");
	}
	public IActionResult Delete(int? id)
	{
		if(id == null)
		{
			return NotFound();
		}
		Category category = _db.Categories.Find(id);
		if(category == null)
		{
			return NotFound();
		}
		return View(category);
	}
	// agar program mengenali kode sebagai action yang berbeda walau namanya sama
	[HttpPost]
	public IActionResult Delete(Category category)
	{
		_db.Categories.Remove(category);
		_db.SaveChanges();
		return RedirectToAction("Index");
	}
}