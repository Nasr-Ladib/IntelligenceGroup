using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Motif
    {
        public int MotifId { get; set; }
        public int IdDoctor { get; set; }
        public string Motifs { get; set; }
        public Doctor Doctor { get; set; }
    }
}
