using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
    public class DoctorAvailableTimes
    {
        public string DoctorID { get; set; }
        [ForeignKey("DoctorID")]
        public virtual Doctor Doctor { get; set; }
        public string AvailabeDayID { get; set; }
        [ForeignKey("AvailabeDayID")]
        public virtual AvailableTime AvailableTime { get; set; }


    }
}
