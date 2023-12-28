using Microsoft.AspNetCore.Mvc;

namespace Hastane_Randevu_Sistemi.Areas.Admin.Controllers
{
	public class HospitalsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
