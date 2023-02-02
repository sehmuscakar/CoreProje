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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
     
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
      
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index"); // bu kontrolün indexine yönlendirecek
        }

        public IActionResult DeleteSkill(int id)//id ye göre silme işlemi yapacaz
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);//ilk önce silme yapılacak idiyi buldurmalıyız manager de id ye göre bulu dodur 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)//burda eğer aynı isimli methot kulanacaksan faklı paremetre ismi vermelisin 
        {
         
            var values = skillManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");//günceleme işkemini yap beni Index sayfasına yönlendir 
        }

    }
}
