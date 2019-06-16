using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Tables
{
    class Rooms
    {        
        public int roomsID { get; set; }
        public int hotelsID { get; set; }
        public int number { get; set; }
        public decimal price { get; set; }
        public int comfortLevel { get; set; }
        public int capability { get; set; }
    }
}
