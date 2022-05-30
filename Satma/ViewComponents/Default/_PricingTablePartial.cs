using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Satma.ViewComponents.Default
{
    public class _PricingTablePartial : ViewComponent
    {
        PrincingTableManager princingTableManager = new PrincingTableManager(new EfPricingTablesDal());
        public IViewComponentResult Invoke()
        {
            var values = princingTableManager.TGetList();
            return View(values);
        }
    }
}
