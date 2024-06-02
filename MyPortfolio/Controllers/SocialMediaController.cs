using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialmedia)
        {
            context.SocialMedias.Add(socialmedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        [HttpGet]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(SocialMediaList));
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var socialMedia = context.SocialMedias.Find(id);
            return View(socialMedia);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
