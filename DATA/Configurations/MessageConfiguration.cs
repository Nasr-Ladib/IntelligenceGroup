using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Configurations
{
   public class MessageConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageConfiguration()
        {
            HasRequired<Chat>(t => t.Chat).WithMany(t => t.ListMessages).WillCascadeOnDelete(true);

        }
    }
}
