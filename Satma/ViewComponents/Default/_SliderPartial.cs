using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Satma.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        HomeManager homeManager = new HomeManager(new EfHomeDal());
        public IViewComponentResult Invoke()
        {
            var values = homeManager.TGetList();
            return View(values);
        }
    }
}
