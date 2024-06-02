using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using NuGet.Protocol.Plugins;

namespace MyPortfolio.ViewComponents
{
    public class _MessageComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke() 
		{
			return View(); 
		}
	}
}
