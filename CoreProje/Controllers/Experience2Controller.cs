using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList()); //burda ajax dağil etik ,SerializeObject listeleme işlemlerinde kullanılacak ama bişeyler gönderilirken deserialize kullanılacak 
            return Json(values);

        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);//burda ajaxa dönüştürdük 
            return Json(values);
        }

        public IActionResult GetByID(int ExprerienceID)
        {
            var v = experienceManager.TGetByID(ExprerienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetByID(id);
            experienceManager.TDelete(v);
            return NoContent();
        }

        //public IActionResult UpdateExperience(Experience p)
        //{
        //    var v = experienceManager.TGetByID(p.ExprerienceID);
        //    experienceManager.TUpdate(v);
        //    var values = JsonConvert.SerializeObject(p);
        //    return Json(values);
        //}
    }
}
