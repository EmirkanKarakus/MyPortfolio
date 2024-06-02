using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(TestimonialList));
        }

		[HttpGet]
		public IActionResult UpdateTestimonial(int id)
		{
			var Testimonial = context.Testimonials.Find(id);
			return View(Testimonial);
		}
		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			context.Testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
	}
}
