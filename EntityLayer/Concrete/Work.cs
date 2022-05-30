using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Work
    {
        [Key]
        public int WorkID { get; set; }
        public int CategoryID { get; set; }
        public string WorkTitle { get; set; }
        public string WorkCategory { get; set; }
        public string WorkImage { get; set; }
        





    }
}
