using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Configurations
{
   public class DoctorConfiguration: EntityTypeConfiguration<Doctor>
    {
        public DoctorConfiguration()
        {
            HasRequired<Calendar>(t => t.Calendar).WithRequiredPrincipal(t => t.Doctor).WillCascadeOnDelete();
            HasMany<MedicalFile>(t => t.ListMedicalFiles)
                .WithMany(t => t.ListDoctors)
                .Map(t =>
                {
                    t.ToTable("Doctor_MedicalFile");
                    t.MapLeftKey("DoctorId");
                    t.MapRightKey("MedicalFileId");
                });
          
        }
    }
}
