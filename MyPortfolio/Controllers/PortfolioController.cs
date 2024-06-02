using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class PortfolioController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		[HttpGet]
		public IActionResult PortfolioList()
		{
			var values = context.Portfolios.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreatePortfolio()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
		[HttpGet]
		public IActionResult DeletePortfolio(int id)
		{
			var value = context.Portfolios.Find(id);
			context.Portfolios.Remove(value);
			context.SaveChanges();
			return RedirectToAction(nameof(PortfolioList));
		}

		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var portfolio = context.Portfolios.Find(id);
			return View(portfolio);
		}
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Update(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
	}
}
