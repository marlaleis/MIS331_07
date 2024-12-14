using Microsoft.AspNetCore.Mvc;

namespace MIS331_07.Controllers
{
	public class TrackGameController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
