using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Home
    {
        [Key]
        public int HomeID { get; set; }
        public string HomeTitle{ get; set; }
        public string HomeDescription { get; set; }
        public bool Status { get; set; }

    }
}
