﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public  interface IGenericDal<T> where T:class// burdan dışardan bir entity günderdik Paremtre olarak, T adında ve bu T where ile bir class daki metotları kullanabilecek  
    {

        void Insert(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetList();

        T GetByID(int id);// T türünde olacak int türünde bir İd alacam 

        List<T> GetbyFilter(Expression<Func<T, bool>> filter);// şartlı çağırma 
    }
}
