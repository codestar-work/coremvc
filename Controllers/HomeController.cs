using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller {
	public ViewResult Index() {
		ViewData["name"] = "World!";
		return View();
	}
}
