using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramwork;
using EntityLayer.conrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Controllers
{
    public class PortfolioController : Controller
    {

        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index()
        {
        
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
 
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
           

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p); //using FluentValidation.Results; bunu eklmen lazım
            // p de name boş olamaz gibi öyle bir parmetre 
            //validations nesnesi ile PortfolioValidator sınıfına bağlanır validatiınları uygular 
            if(results.IsValid) //results.IsValid : results geçerli ise anlamaı var 
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)//eğer sıkıntı varsa bu hatayı döndürecek
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

           
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)//burda eğer aynı isimli methot kulanacaksan faklı paremetre ismi vermelisin 
        {
     
            var values = portfolioManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

           
        }

    }
}
