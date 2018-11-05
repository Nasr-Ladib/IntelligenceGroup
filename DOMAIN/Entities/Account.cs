using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Account
    {
        public int AccountId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Boolean status { get; set; }
        public string role { get; set; }
        public User user { get; set; }
    }
}
