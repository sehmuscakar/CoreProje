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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
 
            var values = serviceManager.TGetList();
            return View(values);

        }
        [HttpGet]
        public IActionResult AddService()
        {
    
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index"); // bu kontrolün indexine yönlendirecek
        }

        public IActionResult DeleteService(int id)//id ye göre silme işlemi yapacaz
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);//ilk önce silme yapılacak idiyi buldurmalıyız manager de id ye göre bulu dodur 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)//burda eğer aynı isimli methot kulanacaksan faklı paremetre ismi vermelisin 
        {
      
            var values = serviceManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");//günceleme işkemini yap beni Index sayfasına yönlendir 
        }
    }
}
