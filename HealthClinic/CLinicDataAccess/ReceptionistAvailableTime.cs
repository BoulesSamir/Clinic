using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
    public class ReceptionistAvailableTime
    {
        public string ReceptionID { get; set; }
        [ForeignKey("ReceptionID")]
        public virtual Receptionist Receptionist { get; set; }
        public string AvailabeDayID { get; set; }
        [ForeignKey("AvailabeDayID")]
        public virtual AvailableTime AvailableTime { get; set; }

    }
}
