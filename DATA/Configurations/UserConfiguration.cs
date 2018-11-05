using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Configurations
{
   public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasRequired<Account>(t => t.account).WithRequiredPrincipal(t => t.user).WillCascadeOnDelete();
            Map<Admin>(c => c.Requires("type").HasValue("Admin"));
            Map<Patient>(c => c.Requires("type").HasValue("Patient"));
            Map<Doctor>(c => c.Requires("type").HasValue("Doctor"));
            
        }
    }
}
