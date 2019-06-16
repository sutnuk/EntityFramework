using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Tables
{
    class Rezervation
    {       
        public int rezervationID { get; set; }
        public int roomsID { get; set; }
        public int usersID { get; set; }        
        public DateTime startRezervation { get; set; }       
        public DateTime endRezervation { get; set; }
    }
}
