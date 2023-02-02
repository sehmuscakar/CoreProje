using EntityLayer.conrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class PortfolioValidator:AbstractValidator<Portfolio>//AbstractValidator using FluentValidation tıklman lazım bide hangi entity kullanacakzsan onu paremetre olarak girmelisin 
    {
        public PortfolioValidator()//  ctor yazıp tap tap yaptığında otomatik olarak gelecek 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");//RuleFor(x=>x.Name). şu kısımdan sonraki gelen metotlar validation metotlarıdır 
                                                                                   // proje adı boş geçilmez NotEmpty() veren mesaj WithMessage

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Göresel alanı boş geçilemez");

            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Göresel2 alanı  boş geçilemez");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");

            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer alanı boş geçilemez");

            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karekterden oluşmak zorundadır.");

       
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı en fazla 100 karekterden oluşmak zorundadır");

            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform alanı boş geçilemez ");
        }
    }
}
