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
    public class FeatureController : Controller
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
         
            var values = featureManager.TGetByID(1); //featuremanager de her zaman 1 numara id ile çalışacağımız için bir 
            return View(values);
        }

     

        
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");//günceleme işkemini yap beni Index sayfasına yönlendir 
       //default içindeki indexi döndür
        }
    }
}
