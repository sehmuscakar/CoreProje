using EntityLayer.conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public  interface IAboutDal:IGenericDal<About>//burda T yerine Entity tanımladık ve generic oldu about kısmı 
    {




        /*
        void Insert(About p);
        void Delete(About p);
        void Update(About p);

        List<About> GetList();// burda T ye karşılık bi referans gelecek  bu About oldu refefans öceden verdiğimiz için tanımlamamız yeterli dışardan geldi yani about refrens sayesinde
                              
        */

    }
}
