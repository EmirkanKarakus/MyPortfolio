using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Portfolios.Count();
            ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v4 = context.Testimonials.Count();
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
