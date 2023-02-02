using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.conrete
{
   public class Feature // bir sınıf tanımladığı zaman ilk önce accsess modifay yap yani erişim belirleyicini public yap 
    {
        // prpertlerini yaz prop yaz iki defa tab yap 

        [Key]
        public int FeatureID { get; set; }

        public string Header { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }


    }
}
