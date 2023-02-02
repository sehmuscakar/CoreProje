using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Controllers
{
    [Authorize(Roles ="Admin")]//bu sayfaya sadece rolü admin olanlar giriş yapabilir  
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
    
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");

        }

        public IActionResult DeleteExperience(int id)//id ye göre silme işlemi yapacaz
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);//ilk önce silme yapılacak idiyi buldurmalıyız manager de id ye göre bulu dodur 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)//burda eğer aynı isimli methot kulanacaksan faklı paremetre ismi vermelisin 
        {
            var values = experienceManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
        
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");//günceleme işkemini yap beni Index sayfasına yönlendir 
        }
    }

}
