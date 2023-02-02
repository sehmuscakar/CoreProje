using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService// eğer bi interfaceyi miras alacaksan onu impement etmen lazım ki metotları gelsin 
    {//IAboutService den de IGenericService yi miras aldığımız için IGenericService<About> daki metotlar geldi bağlantılı olarak düşün yani 

        IAboutDal _aboutDal;//büyle bi parmetre türetik fayl de diyebiliriz bunu kullanarak generate contsractır oluştur AboutManager burdan 

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t); // . dan sonra gelen metotları biz IGenericDal da tanımladık
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID( id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();// burda paremtre almıyacak cünkü genericdal da paremtre vermedik List<About> burda About olarak entity tanımlı onu göre listeleme yapacak 
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        /*
public List<About> TGetList(About t)//bu önceden genericdal da paremtre tanımlandığı için geliyor herhalde 
{
   throw new NotImplementedException();
}
*/
        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
