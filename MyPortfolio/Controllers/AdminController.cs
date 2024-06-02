using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using System.Linq;

namespace MyPortfolio.Controllers
{
    public class AdminController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string AdminName, string AdminPassword)
        {
            var admin = context.Admins.FirstOrDefault(x => x.AdminName == AdminName && x.AdminPassword == AdminPassword);
            if (admin != null)
            {
                return RedirectToAction("Index", "Statistic");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre.";
                return View("Index");
            }
        }
    }
}
