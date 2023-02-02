using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen  Adınızı Girin")] // arka planda bu yazı gözükür
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı Girin")] // arka planda bu yazı gözükür
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen resim url değeri Girin")] // arka planda bu yazı gözükür
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Girin")] // arka planda bu yazı gözükür
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi tekrar Girin")] // arka planda bu yazı gözükür
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil!")] // girilen şifre ile password yanı olmalı 
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")] // arka planda bu yazı gözükür
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Girin")]

        public string  Mail { get; set; }

    }
}
