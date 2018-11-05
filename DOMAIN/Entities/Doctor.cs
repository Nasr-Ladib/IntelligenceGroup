using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public enum Speciality { Neurology,Pdiatrics}
    public class Doctor:User
    {
        public Speciality speciality { get; set; }
        public string bioghrapy { get; set; }
        public int officeNumber { get; set; }
        public int cnam { get; set; }
        public string webSite { get; set; }
        public float tarif { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public string motif { get; set; }
        public Calendar Calendar { get; set; }
        public virtual ICollection<Patient> ListPatients { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<MedicalFile> ListMedicalFiles { get; set; }
        public virtual ICollection<Appointment> ListAppointments { get; set; }
        public virtual ICollection<Chat> ListChats { get; set; }

        public virtual ICollection<Motif> ListMotifs { get; set; }






    }
}
