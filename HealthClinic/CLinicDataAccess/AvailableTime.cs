using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
    public enum Day { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class AvailableTime:BaseEntity
    {
        public Day AvailableDay { get; set; }
        public virtual ICollection<DoctorAvailableTimes> DoctorAvailableTimes { get; set; }
        public virtual ICollection<ReceptionistAvailableTime> ReceptionistAvailableTimes { get; set; }


    }
}
