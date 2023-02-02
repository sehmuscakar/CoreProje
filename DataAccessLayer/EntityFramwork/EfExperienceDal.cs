using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramwork
{
 public   class EfExperienceDal:GenericRepository<Experience>,IExperienceDal
    {
    }
}
