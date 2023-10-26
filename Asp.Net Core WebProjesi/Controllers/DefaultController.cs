using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_WebProjesi.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}

		public PartialViewResult NavbarPartial()
		{
			return PartialView();
		}
    }
}
