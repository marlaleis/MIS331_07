using Microsoft.AspNetCore.Mvc;

namespace MIS331_07.Controllers
{
	public class PlayController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
