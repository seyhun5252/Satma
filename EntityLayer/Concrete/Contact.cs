using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactTitle { get; set; }
        public string ContactDesciption { get; set; }
        public string Adress { get; set; }
        public string WorkTime { get; set; }
        public string Phone { get; set; }
    }
}
