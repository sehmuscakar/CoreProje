using CoreProje.Areas.Writer.Models;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        // burda veriyi getirme işlemi yapıyoruz otantik olmasını sağlıyoruz 
        private readonly UserManager<WriterUser> _userManager;// burda entity ile getirdik 

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //güncelleme için modele atamalarımızı yaptık
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureURL = values.ImageUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();//yol all
                var extension = Path.GetExtension(p.Picture.FileName);//uzantının yolunu all
                var imagename = Guid.NewGuid() + extension;//uzantıdan gelen değeri sonuna ekle ,benzersiz isim oluşturur
                var savelacation = resource + "/wwwroot/userimage/" + imagename;//kayıt edileceği lokasyon
                var stream = new FileStream(savelacation, FileMode.Create);//stream:akış,büylece resim dosyası oluşturulmuş olacak 
                await p.Picture.CopyToAsync(stream);//kopyalama işini yapmış olduk
                user.ImageUrl = imagename;
            }
            // burda atamalarımızı yaptık 
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password); //burda şifre günceleme işlemini yaptık 
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");

            }
            
            return View();
        }
      }
}
