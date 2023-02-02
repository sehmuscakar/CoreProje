using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.ViewComponents.Feature
{
    public class FeatureList: ViewComponent//ViewComponent bu sınıftan miras alacak featurelist, ViewComponent sınıfı using Microsoft.AspNetCore.Mvc; bu  kütüphanenin içinde 
        // bir controller a yaklaştığın gibi yaklaş 
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke() //Invoke bu isimli metotlar tanımlanır burda 
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
