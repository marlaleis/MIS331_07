using Microsoft.AspNetCore.Mvc;
using MIS331_07.Data;
using MIS331_07.Models;

namespace MIS331_07.Controllers
{
    public class PriceListController : Controller
    {
        readonly ApplicationDbContext _db;
        public PriceListController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<PriceList> objPriceList;

            objPriceList = _db.PriceLists.ToList();

            return View(objPriceList);
        }


		public IActionResult Create()
		{

			return View();
		}

	}
}
