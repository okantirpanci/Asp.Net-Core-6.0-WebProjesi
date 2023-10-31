using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

		public PartialViewResult FooterPartial()
		{
			return PartialView();
		}

		public PartialViewResult ScriptPartial()
		{
			return PartialView();
		}

		[HttpGet]
		public PartialViewResult SendMessagePartial()
		{
			return PartialView();
		}

        [HttpPost]
        public PartialViewResult SendMessagePartial(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            messageManager.TAdd(p);
            return PartialView();
        }
    }
}
