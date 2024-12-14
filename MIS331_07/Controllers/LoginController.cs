using Microsoft.AspNetCore.Mvc;

namespace MIS331_07.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
