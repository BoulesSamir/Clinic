using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
    public class Patient:BaseEntity
    {
        prop
        
        public virtual ICollection<DoctorPatients> Doctors { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
