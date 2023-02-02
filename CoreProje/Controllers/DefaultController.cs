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
    public class DefaultController : Controller
    {
        [AllowAnonymous]// hiç kimse otantike olmasa bile bu sayfa açılması lazım 
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial() // burda partial view i oluşturduk add view den 
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());//mesajın kaydedildiği tarihi veritabanına yansıtsın 
            p.Status = true;//başlangıçta aktif olsun
            messageManager.TAdd(p);
            return PartialView();
        }

    }
}
