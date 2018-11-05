using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Configurations
{
    public class ChatConfiguration:EntityTypeConfiguration<Chat>
    {
        public ChatConfiguration()
        {
            HasRequired<Patient>(t => t.Patient).WithMany(t => t.ListChats).HasForeignKey(t=>t.PatientId).WillCascadeOnDelete(false);

        }
    }
}
