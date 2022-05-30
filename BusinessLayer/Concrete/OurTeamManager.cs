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
    public class OurTeamManager : IOurTeamService
    {
        IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TAdd(OurTeam t)
        {
            _ourTeamDal.Insert(t);
        }

        public void TDelete(OurTeam t)
        {
            _ourTeamDal.Delete(t);
        }

        public OurTeam TGetByID(int id)
        {
            return _ourTeamDal.TGetByID(id);
        }

        public List<OurTeam> TGetList()
        {
            return _ourTeamDal.GetList();
        }

        public void TUpdate(OurTeam t)
        {
            _ourTeamDal.Update(t);
        }
    }
}
