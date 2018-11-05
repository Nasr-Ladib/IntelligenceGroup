using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Calendar
    {
        public int CalendarId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public DateTime dateCal { get; set; }
        public bool dispo { get; set; }
        public Doctor Doctor { get; set; }
    }
}
