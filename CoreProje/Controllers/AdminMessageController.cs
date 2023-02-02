using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Controllers
{
    public class AdminMessageController : Controller
    {

        WriterMessageManager WriterMessageManager = new WriterMessageManager(new EfWriterDal());// mesajları listelemek için 
        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = WriterMessageManager.GetListReceiverMessage(p);//alıcısı olduğumuz mesajlar
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = WriterMessageManager.GetListSenderMessage(p);//alıcısı olduğumuz mesajlar
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values =WriterMessageManager.TGetByID(id);
            return View(values);

        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = WriterMessageManager.TGetByID(id);
            WriterMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();//mesaj gönderilirken alıcı adının eklenmesi
            p.ReceiverName = usernamesurname;
            WriterMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList"); // bu kontrolün indexine yönlendirecek
        }

    }
}
