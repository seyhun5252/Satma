using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int ServiesID { get; set; }
        public string ServiesTitle { get; set; }
        public string ServiesDescription { get; set; }
    }
}
