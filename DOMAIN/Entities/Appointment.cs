using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment
    {
        [Key,Column(Order=0)]
        public int IdDoctor { get; set; }
        [Key, Column(Order =1)]
        public int IdPatient { get; set; }
        [Key, Column(Order = 2)]
        public DateTime date { get; set; }
        public bool status { get; set; }
        public int rate { get; set; }
        public string comment { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Cursus Cursus { get; set; }
        public string Motif { get; set; }



    }
}
