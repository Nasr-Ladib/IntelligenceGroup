using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Configurations
{
  public  class PatientConfiguration : EntityTypeConfiguration<Patient>
    {
        public PatientConfiguration()
        {
            HasRequired<MedicalFile>(t => t.MedicalFile).WithRequiredPrincipal(t => t.Patient).WillCascadeOnDelete();

        }
    }
}
