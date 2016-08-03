using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class HomeController : Controller {
	public ViewResult Index() {
		ViewData["name"] = "World!";
		return View();
	}
}
