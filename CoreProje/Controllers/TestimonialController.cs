using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)//burda eğer aynı isimli methot kulanacaksan faklı paremetre ismi vermelisin 
        {
            var values = testimonialManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {

            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");//günceleme işkemini yap beni Index sayfasına yönlendir 
        }
    }
}
