using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PrincingTableManager : IPrincingTableService
    {
        IPricingTablesDal _pricingTablesDal;

        public PrincingTableManager(IPricingTablesDal pricingTablesDal)
        {
            _pricingTablesDal = pricingTablesDal;
        }

        public void TAdd(PricingTables t)
        {
            _pricingTablesDal.Insert(t);
        }

        public void TDelete(PricingTables t)
        {
            _pricingTablesDal.Delete(t);
        }

        public PricingTables TGetByID(int id)
        {
           return _pricingTablesDal.TGetByID(id);
        }

        public List<PricingTables> TGetList()
        {
            return _pricingTablesDal.GetList();
        }

        public void TUpdate(PricingTables t)
        {
            _pricingTablesDal.Update(t);
        }
    }
}
