using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogName { get; set; }
        public string Image { get; set; }
        public DateTime BlogUploadDate { get; set; }
        public string BlogDesciption { get; set; }
        public bool Status { get; set; }

    }
}
