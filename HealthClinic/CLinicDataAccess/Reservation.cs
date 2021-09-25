using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
    /// <summary>
    /// one reserve for one patient
    /// </summary>
   public class Reservation:BaseEntity
    {
        public Patient Patient { get; set; }

        public double Cost { get; set; }
        public bool IsPaid { get; set; }
        public DateTime ReservationDate { get; set; }

    }
}
