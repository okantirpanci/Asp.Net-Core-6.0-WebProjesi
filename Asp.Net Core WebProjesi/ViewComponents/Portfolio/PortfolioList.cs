using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_WebProjesi.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}
