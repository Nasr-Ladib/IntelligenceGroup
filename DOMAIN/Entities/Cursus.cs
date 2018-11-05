using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cursus
    {
        public int CursusId  { get; set; }
        public string treatment { get; set; }
        public string description { get; set; }
        public string report { get; set; }
        public bool status { get; set; }
        public DateTime dateCursus { get; set; }
        public virtual ICollection<Appointment> Appoitement { get; set; }
        public MedicalFile MedicalFile { get; set; }

    }
}
