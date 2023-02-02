using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        // güncelleme işlemi için gerekli bunlar
        public string Name  { get; set; }
        public string Surname  { get; set; }
        public string Password  { get; set; }
        public string PasswordConfirm  { get; set; }
        public string PictureURL  { get; set; }
        public  IFormFile Picture { get; set; } //IFormFile  dosyanın wwwwrootun içine kayıt olması için gerekli olan tür 
}
    }

