using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient:User
    {
        public virtual ICollection<Doctor> ListDoctors { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual MedicalFile MedicalFile { get; set; }
        public virtual ICollection<Appointment> ListAppointments { get; set; }
        public virtual ICollection<Chat> ListChats { get; set; }



    }
}
