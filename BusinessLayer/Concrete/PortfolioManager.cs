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
    public class PortfolioManager : IPortfolioService
    {

        IPortfolioDal _portflioDal;

        public PortfolioManager(IPortfolioDal portflioDal)
        {
            _portflioDal = portflioDal;
        }

        public void TAdd(Portfolio t)
        {
            _portflioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portflioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portflioDal.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portflioDal.GetList();
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            _portflioDal.Update(t);
        }
    }
}
