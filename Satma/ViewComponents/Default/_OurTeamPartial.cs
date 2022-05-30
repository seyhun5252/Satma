using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Satma.ViewComponents.Default
{
    public class _OurTeamPartial : ViewComponent
    {
        OurTeamManager ourTeamManager = new OurTeamManager(new EfOurTeamDal());
        public IViewComponentResult Invoke()
        {
            var values = ourTeamManager.TGetList();
            return View(values);
        }
    }
}
