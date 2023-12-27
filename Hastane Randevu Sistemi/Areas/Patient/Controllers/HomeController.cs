using Microsoft.AspNetCore.Mvc;

namespace Hastane_Randevu_Sistemi.Areas.Patient.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
