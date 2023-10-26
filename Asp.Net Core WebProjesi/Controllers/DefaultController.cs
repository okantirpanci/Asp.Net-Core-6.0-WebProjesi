using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_WebProjesi.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
