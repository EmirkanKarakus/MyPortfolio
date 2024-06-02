using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
                ViewBag.v1 = portfolioContext.Contacts.Select(x => x.Title).FirstOrDefault();
                ViewBag.v2 = portfolioContext.Contacts.Select(x => x.Description).FirstOrDefault();
                ViewBag.v3 = portfolioContext.Contacts.Select(x => x.Phone1).FirstOrDefault();
                ViewBag.v4 = portfolioContext.Contacts.Select(x => x.Phone2).FirstOrDefault();
                ViewBag.v5 = portfolioContext.Contacts.Select(x => x.Email1).FirstOrDefault();
                ViewBag.v6 = portfolioContext.Contacts.Select(x => x.Email2).FirstOrDefault();
                ViewBag.v7 = portfolioContext.Contacts.Select(x => x.Address).FirstOrDefault();
                return View();
        }
	}
}
