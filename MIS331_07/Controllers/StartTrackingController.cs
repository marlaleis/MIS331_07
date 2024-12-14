using Microsoft.AspNetCore.Mvc;

namespace MIS331_07.Controllers
{
	public class StartTrackingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
