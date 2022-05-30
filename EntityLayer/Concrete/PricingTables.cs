using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PricingTables
    {
        [Key]
        public int PriceID { get; set; }
        public string PricingTablesName { get; set; }
        public int Price { get; set; }
        public int Storage { get; set; }
        public int ActiveProjects { get; set; }
        public string EmailSupport { get; set; }
        


    }
}
