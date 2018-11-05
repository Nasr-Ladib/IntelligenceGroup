namespace DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.IdentityUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.IdentityUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IdentityUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.Cursus",
                c => new
                    {
                        CursusId = c.Int(nullable: false, identity: true),
                        treatment = c.String(),
                        description = c.String(),
                        report = c.String(),
                        status = c.Boolean(nullable: false),
                        dateCursus = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        MedicalFile_MedicalFileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CursusId)
                .ForeignKey("dbo.MedicalFiles", t => t.MedicalFile_MedicalFileId)
                .Index(t => t.MedicalFile_MedicalFileId);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        IdDoctor = c.Int(nullable: false),
                        IdPatient = c.Int(nullable: false),
                        date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        status = c.Boolean(nullable: false),
                        rate = c.Int(nullable: false),
                        comment = c.String(),
                        Motif = c.String(),
                        Patient_Id = c.Int(),
                        Doctor_Id = c.Int(),
                        Cursus_CursusId = c.Int(),
                    })
                .PrimaryKey(t => new { t.IdDoctor, t.IdPatient, t.date })
                .ForeignKey("dbo.User", t => t.Patient_Id)
                .ForeignKey("dbo.User", t => t.Doctor_Id)
                .ForeignKey("dbo.Cursus", t => t.Cursus_CursusId)
                .Index(t => t.Patient_Id)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Cursus_CursusId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        birthday = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        address = c.String(),
                        createdDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Role = c.String(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        password = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        Login = c.String(),
                        speciality = c.Int(),
                        bioghrapy = c.String(),
                        officeNumber = c.Int(),
                        cnam = c.Int(),
                        webSite = c.String(),
                        tarif = c.Single(),
                        latitude = c.Int(),
                        longitude = c.Int(),
                        motif = c.String(),
                        Doctor_Id = c.Int(),
                        Patient_Id = c.Int(),
                        Doctor_Id1 = c.Int(),
                        Patient_Id1 = c.Int(),
                        type = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Doctor_Id)
                .ForeignKey("dbo.User", t => t.Patient_Id)
                .ForeignKey("dbo.User", t => t.Doctor_Id1)
                .ForeignKey("dbo.User", t => t.Patient_Id1)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Patient_Id)
                .Index(t => t.Doctor_Id1)
                .Index(t => t.Patient_Id1);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false),
                        username = c.String(),
                        password = c.String(),
                        status = c.Boolean(nullable: false),
                        role = c.String(),
                    })
                .PrimaryKey(t => t.AccountId)
                .ForeignKey("dbo.User", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.CustomUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CustomUserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CustomUserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        CustomRole_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .ForeignKey("dbo.CustomRole", t => t.CustomRole_Id)
                .Index(t => t.UserId)
                .Index(t => t.CustomRole_Id);
            
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        dateChat = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => new { t.PatientId, t.DoctorId, t.dateChat })
                .ForeignKey("dbo.User", t => t.DoctorId)
                .ForeignKey("dbo.User", t => t.PatientId)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        dateMessage = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        content = c.String(),
                        Chat_PatientId = c.Int(nullable: false),
                        Chat_DoctorId = c.Int(nullable: false),
                        Chat_dateChat = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Chats", t => new { t.Chat_PatientId, t.Chat_DoctorId, t.Chat_dateChat }, cascadeDelete: true)
                .Index(t => new { t.Chat_PatientId, t.Chat_DoctorId, t.Chat_dateChat });
            
            CreateTable(
                "dbo.MedicalFiles",
                c => new
                    {
                        MedicalFileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicalFileId)
                .ForeignKey("dbo.User", t => t.MedicalFileId, cascadeDelete: true)
                .Index(t => t.MedicalFileId);
            
            CreateTable(
                "dbo.Calendars",
                c => new
                    {
                        CalendarId = c.Int(nullable: false),
                        startTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        endTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        dateCal = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        dispo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CalendarId)
                .ForeignKey("dbo.User", t => t.CalendarId, cascadeDelete: true)
                .Index(t => t.CalendarId);
            
            CreateTable(
                "dbo.Motifs",
                c => new
                    {
                        MotifId = c.Int(nullable: false, identity: true),
                        IdDoctor = c.Int(nullable: false),
                        Motifs = c.String(),
                        Doctor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.MotifId)
                .ForeignKey("dbo.User", t => t.Doctor_Id)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.CustomRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doctor_MedicalFile",
                c => new
                    {
                        DoctorId = c.Int(nullable: false),
                        MedicalFileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DoctorId, t.MedicalFileId })
                .ForeignKey("dbo.User", t => t.DoctorId)
                .ForeignKey("dbo.MedicalFiles", t => t.MedicalFileId)
                .Index(t => t.DoctorId)
                .Index(t => t.MedicalFileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomUserRoles", "CustomRole_Id", "dbo.CustomRole");
            DropForeignKey("dbo.Cursus", "MedicalFile_MedicalFileId", "dbo.MedicalFiles");
            DropForeignKey("dbo.Appointments", "Cursus_CursusId", "dbo.Cursus");
            DropForeignKey("dbo.User", "Patient_Id1", "dbo.User");
            DropForeignKey("dbo.User", "Doctor_Id1", "dbo.User");
            DropForeignKey("dbo.Motifs", "Doctor_Id", "dbo.User");
            DropForeignKey("dbo.Doctor_MedicalFile", "MedicalFileId", "dbo.MedicalFiles");
            DropForeignKey("dbo.Doctor_MedicalFile", "DoctorId", "dbo.User");
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.User");
            DropForeignKey("dbo.Calendars", "CalendarId", "dbo.User");
            DropForeignKey("dbo.MedicalFiles", "MedicalFileId", "dbo.User");
            DropForeignKey("dbo.User", "Patient_Id", "dbo.User");
            DropForeignKey("dbo.Chats", "PatientId", "dbo.User");
            DropForeignKey("dbo.Messages", new[] { "Chat_PatientId", "Chat_DoctorId", "Chat_dateChat" }, "dbo.Chats");
            DropForeignKey("dbo.Chats", "DoctorId", "dbo.User");
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.User");
            DropForeignKey("dbo.User", "Doctor_Id", "dbo.User");
            DropForeignKey("dbo.CustomUserRoles", "UserId", "dbo.User");
            DropForeignKey("dbo.CustomUserLogins", "UserId", "dbo.User");
            DropForeignKey("dbo.CustomUserClaims", "UserId", "dbo.User");
            DropForeignKey("dbo.Accounts", "AccountId", "dbo.User");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserLogins", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserClaims", "IdentityUser_Id", "dbo.IdentityUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropIndex("dbo.Doctor_MedicalFile", new[] { "MedicalFileId" });
            DropIndex("dbo.Doctor_MedicalFile", new[] { "DoctorId" });
            DropIndex("dbo.Motifs", new[] { "Doctor_Id" });
            DropIndex("dbo.Calendars", new[] { "CalendarId" });
            DropIndex("dbo.MedicalFiles", new[] { "MedicalFileId" });
            DropIndex("dbo.Messages", new[] { "Chat_PatientId", "Chat_DoctorId", "Chat_dateChat" });
            DropIndex("dbo.Chats", new[] { "DoctorId" });
            DropIndex("dbo.Chats", new[] { "PatientId" });
            DropIndex("dbo.CustomUserRoles", new[] { "CustomRole_Id" });
            DropIndex("dbo.CustomUserRoles", new[] { "UserId" });
            DropIndex("dbo.CustomUserLogins", new[] { "UserId" });
            DropIndex("dbo.CustomUserClaims", new[] { "UserId" });
            DropIndex("dbo.Accounts", new[] { "AccountId" });
            DropIndex("dbo.User", new[] { "Patient_Id1" });
            DropIndex("dbo.User", new[] { "Doctor_Id1" });
            DropIndex("dbo.User", new[] { "Patient_Id" });
            DropIndex("dbo.User", new[] { "Doctor_Id" });
            DropIndex("dbo.Appointments", new[] { "Cursus_CursusId" });
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            DropIndex("dbo.Cursus", new[] { "MedicalFile_MedicalFileId" });
            DropIndex("dbo.IdentityUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropTable("dbo.Doctor_MedicalFile");
            DropTable("dbo.CustomRole");
            DropTable("dbo.Motifs");
            DropTable("dbo.Calendars");
            DropTable("dbo.MedicalFiles");
            DropTable("dbo.Messages");
            DropTable("dbo.Chats");
            DropTable("dbo.CustomUserRoles");
            DropTable("dbo.CustomUserLogins");
            DropTable("dbo.CustomUserClaims");
            DropTable("dbo.Accounts");
            DropTable("dbo.User");
            DropTable("dbo.Appointments");
            DropTable("dbo.Cursus");
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.IdentityUsers");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityRoles");
        }
    }
}
