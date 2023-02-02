using CoreProje.Areas.Writer.Models;
using EntityLayer.conrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;// asp.net core ıdentity ile beraber hazır gelen bir sınıf ,buraya cunstroctor uygula 

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
           
                WriterUser w = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImageUrl = p.ImageUrl
                };
            if (p.Password == p.ConfirmPassword) 
            {


            var result = await _userManager.CreateAsync( w, p.Password);//bi hesap oluşturma işlemi olduğu için bunu kullandık ,birinci paremtre yukardaki nesne ikinci şifre
            if (result.Succeeded)  //eğer ekleme işlemi başarılı ise 
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);//hatanın açıklamasını modelmize gönder
                }
            }

            }
            return View(p);
        }
    }
}
