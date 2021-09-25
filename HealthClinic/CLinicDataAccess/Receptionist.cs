using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
     public class Receptionist:BaseEntity
    {
        public double Salary { get; set; }
        public virtual ICollection<ReceptionistAvailableTime> ReceptionistAvailableTimes { get; set; }


    }
}
