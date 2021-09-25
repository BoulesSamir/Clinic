using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinicDataAccess
{
    public class Department : BaseEntity
    {
        
        public string Name { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
