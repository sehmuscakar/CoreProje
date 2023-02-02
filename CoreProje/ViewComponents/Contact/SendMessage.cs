using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
      
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());//mesajın kaydedildiği tarihi veritabanına yansıtsın 
        //    p.Status = true;//başlangıçta aktif olsun
        //    messageManager.TAdd(p); //mesaj sınıfından bi parametre gelecek onu messagemanager içine ekle
        //    return View();
        //}
    }
}
