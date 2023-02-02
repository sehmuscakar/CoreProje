using EntityLayer.conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
 public   interface IAboutService:IGenericService<About>// büylece geric oldu About T karşılık geldi 
    {
        /*
        //eğer generic yapmasaydık büyle tek tek her entitye bu metotları yazacaktık
        void AddAbout(About p);//about türünde p paremtersi 

        void DeleteAbout(About p);

        */
    }
}
