using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public interface IController<T>
{
	IActionResult Get();
	IActionResult Get(int id);
	IActionResult Create(T data);
	IActionResult Update(int id, T data);
	IActionResult Delete(int id);
}
