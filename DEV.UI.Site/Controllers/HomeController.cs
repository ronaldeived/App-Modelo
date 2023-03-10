using System;
using Microsoft.AspNetCore.Mvc;

namespace DEV.UI.Site.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

