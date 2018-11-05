using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Configurations
{
    public   class CursusConfiguration : EntityTypeConfiguration<Cursus>
    {
        public CursusConfiguration()
        {
            HasMany<Appointment>(t => t.Appoitement).WithOptional(t => t.Cursus);
            HasRequired<MedicalFile>(t => t.MedicalFile).WithMany(t => t.ListCursus);

        }
    }
}
