using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
    
    public   class Doctor:BaseEntity
    {
        public double Salary { get; set; }
        public double ExamCost { get; set; }

        //public double Percentage { get; set; } // percentage * cost الاعادة

        public virtual ICollection<DoctorAvailableTimes> DoctorAvailableTimes { get; set; }

        public virtual ICollection<DoctorPatients>  Patients { get; set; }
        public string DepatmentID { get; set; }
        public virtual Department  Department{ get; set; }
    }
}
