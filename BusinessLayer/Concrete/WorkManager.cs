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
    public class WorkManager : IWorkService
    {
        IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public void TAdd(Work t)
        {
            _workDal.Insert(t);
        }

        public void TDelete(Work t)
        {
            _workDal.Delete(t);
        }

        public Work TGetByID(int id)
        {
            return _workDal.TGetByID(id);
        }

        public List<Work> TGetList()
        {
            return _workDal.GetList();
        }

        public void TUpdate(Work t)
        {
            _workDal.Update(t);
        }
    }
}
