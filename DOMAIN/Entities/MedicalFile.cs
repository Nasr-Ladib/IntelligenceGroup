using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MedicalFile
    {
        public int MedicalFileId { get; set; }
        public virtual ICollection<Doctor> ListDoctors { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Cursus> ListCursus { get; set; }



    }
}
