using DATA.Configurations;
using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
   public class Context : IdentityDbContext<IdentityUser, IdentityRole, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        public static Context Create()
        {
            return new Context();
        }
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }
        public Context() :base("name=Epione")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CursusConfiguration());
            modelBuilder.Configurations.Add(new DoctorConfiguration());
            modelBuilder.Configurations.Add(new MessageConfiguration());
            modelBuilder.Configurations.Add(new PatientConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Conventions.Add(new Conventions.DateTime2Convention());
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            modelBuilder.Entity<User>().Property(r => r.UserName).HasColumnName("Login");
            //  modelBuilder.Entity<Client>().Property(r => r.Id).HasColumnName("id_User");
            modelBuilder.Entity<User>().Property(r => r.PasswordHash).HasColumnName("password");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<CustomRole>().ToTable("CustomRole");

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();





        }

    }
}
