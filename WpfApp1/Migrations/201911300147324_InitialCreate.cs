namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Builds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDUserInfo = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Address = c.String(),
                        Area = c.Int(nullable: false),
                        RoomsCount = c.Int(nullable: false),
                        IdCertificate = c.Int(nullable: false),
                        Certificate_ID = c.Int(),
                        UserInformation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Certificates", t => t.Certificate_ID)
                .ForeignKey("dbo.UserInformations", t => t.UserInformation_ID)
                .Index(t => t.Certificate_ID)
                .Index(t => t.UserInformation_ID);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RegistrationNumber = c.String(),
                        PlaceRegistration = c.String(),
                        PurchaseDate = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mark = c.String(),
                        Model = c.String(),
                        EngineID = c.Int(nullable: false),
                        UserInformation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Engines", t => t.EngineID, cascadeDelete: true)
                .ForeignKey("dbo.UserInformations", t => t.UserInformation_ID)
                .Index(t => t.EngineID)
                .Index(t => t.UserInformation_ID);
            
            CreateTable(
                "dbo.Engines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Volume = c.Int(nullable: false),
                        EngineType = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Admin = c.Boolean(nullable: false),
                        userInformation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInformations", t => t.userInformation_ID)
                .Index(t => t.userInformation_ID);
            
            CreateTable(
                "dbo.UserInformations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Firstname = c.String(),
                        Surname = c.String(),
                        State = c.Int(),
                        Gender = c.Int(),
                        IdentificationCode = c.String(),
                        Passport = c.String(),
                        DateOfBirthday = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        BuildID = c.Int(nullable: false),
                        TransportID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "userInformation_ID", "dbo.UserInformations");
            DropForeignKey("dbo.Transports", "UserInformation_ID", "dbo.UserInformations");
            DropForeignKey("dbo.Builds", "UserInformation_ID", "dbo.UserInformations");
            DropForeignKey("dbo.Transports", "EngineID", "dbo.Engines");
            DropForeignKey("dbo.Builds", "Certificate_ID", "dbo.Certificates");
            DropIndex("dbo.Users", new[] { "userInformation_ID" });
            DropIndex("dbo.Transports", new[] { "UserInformation_ID" });
            DropIndex("dbo.Transports", new[] { "EngineID" });
            DropIndex("dbo.Builds", new[] { "UserInformation_ID" });
            DropIndex("dbo.Builds", new[] { "Certificate_ID" });
            DropTable("dbo.UserInformations");
            DropTable("dbo.Users");
            DropTable("dbo.Engines");
            DropTable("dbo.Transports");
            DropTable("dbo.Certificates");
            DropTable("dbo.Builds");
        }
    }
}
