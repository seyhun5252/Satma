using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OurTeam
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string OurTeamStatus { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkledin { get; set; }
        public string Image { get; set; }

    }
}
