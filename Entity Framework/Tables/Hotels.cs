using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Tables
{
    class Hotels
    {       
        public int hotelsID { get; set; }
        public string name { get; set; }
        public int foundationYear { get; set; }
        public string address { get; set; }
        public bool isActive { get; set; }
    }
}
