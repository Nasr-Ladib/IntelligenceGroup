using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Chat
    {
        [Key, Column(Order = 0)]
        public int PatientId { get; set; }
        [Key, Column(Order = 1)]
        public int DoctorId { get; set; }
        [Key, Column(Order = 2)]
        public DateTime dateChat { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Message> ListMessages { get; set; }



    }
}
