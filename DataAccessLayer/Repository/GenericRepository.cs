using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class//
        //GenericRepository<T>  bu generic yuntemi T yerine artık skill ,about vs hangisi gelirse gelir 
    {

        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);//t den gelen paremteriyi kaldırır
            c.SaveChanges();//veritabanına yansıması için değişiklikleri kaydetmen lazım 

        }

        public List<T> GetbyFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();// istediğim şarta göre ben listeleme işelemini gerçekleştirmiş olacam ,Linq Expression Filter böyle kullanılıyor 
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);//id ye göre arama işlemmi yapacak //return unutma void değil
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

     
        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();

        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();

        }
    }
}
