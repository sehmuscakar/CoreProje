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
    public class WriterUserController : Controller
    {
        WriterUserManager userManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(userManager.TGetList()); //burda ajax dağil etik ,SerializeObject listeleme işlemlerinde kullanılacak ama bişeyler gönderilirken deserialize kullanılacak 
            return Json(values);

        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            userManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);//burda ajaxa dönüştürdük 
            return Json(values);
        }
  
    }
}
